using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using OpenQA.Selenium.Support.UI;
using System.Globalization;

namespace SeminarHelper
{
    /**
     * This class allows simple data fetch either from IS (using ChromeDriver)
     * or from file (where it was saved previously).
     * It can also saved subjects to file.
     */
    static class Parser
    {
        // helper variables used for storing parsed results from multiple threads
        private static List<Subject> subjects = new ();
        private static List<(Score, string)> scoreLinks = new();
        private static string output = "";

        
        // load subjets from file given by "path"
        public static List<Subject> FromFile(string path)
        {
            var loadedSubjects = new List<Subject>();
            var jsonString = "";

            try
            {
                jsonString = File.ReadAllText(path);
            }
            catch (Exception)
            {

                MessageBox.Show("Soubor nejde otevřít!");
                return loadedSubjects;
            }

            try
            {
                loadedSubjects = JsonSerializer.Deserialize<List<Subject>>(jsonString);
            }
            catch (Exception)
            {
                MessageBox.Show("Soubor nemá validní formát!");
            }

            return loadedSubjects;
        }

        // save currently loaded objects to file given by "path"
        public static void ToFile(string path, List<Subject> subjects)
        {
            string jsonString = JsonSerializer.Serialize(subjects);
            try
            {
                File.WriteAllText(path, jsonString);
                MessageBox.Show("Uložení do souboru bylo úspěšné");

            }
            catch (Exception)
            {
                MessageBox.Show("Do souboru nejde zapsat!");
            }
        }

        // load data from IS using web driver; user must be signed in before calling this function.
        public static async Task<List<Subject>> FromIS(ChromeDriver driver)
        {
            // open new window to show progress
            var window = new PopupTextWindow("");
            window.Show();
            
            // go to registration page in IS
            driver.Url = "https://is.muni.cz/auth/student/zapis?obdobi=8403;studium=873104";

            // iterate through every enrolled subject and fetch data
            if (!window.IsDisposed)
            {
                window.textBox.AppendText("--- PARSOVÁNÍ PŘEDMĚTŮ ---" + Environment.NewLine);
            }
            var elements = driver.FindElementsByXPath("/html/body/div[1]/div[2]/div[2]/main/form/table[1]/tbody/tr");
            var tasks = new List<Task>();
            foreach (var element in elements)
            {
                if (element.GetAttribute("class") == "predm_hlavni")
                {
                    tasks.Add(ParseSubject(driver, element, window));
                    if (!window.IsDisposed && output != "")
                    {
                        window.textBox.AppendText(output);
                        output = "";
                    }
                    // wait 3 sec to prevent opening too much web drivers at once nad crashing and freezing :P
                    await Task.Delay(3000);
                }
            }

            // wait until parsing is finished
            foreach (var task in tasks) 
            {
                await task;
            }

            while (!AllTasksCompleted(tasks))
            {
                await Task.Delay(1000);
                if (!window.IsDisposed && output != "")
                {
                    window.textBox.AppendText(output);
                    output = "";
                }
            }

            // parse each tutor's score (if he has one)
            if (!window.IsDisposed)
            {
                window.textBox.AppendText(output);
                output = "";
                window.textBox.AppendText(Environment.NewLine + "--- PARSOVÁNÍ HODNOCENÍ CVIČÍCÍCH ---" + Environment.NewLine);
            }
            var scoreTask =  Task.Run( () => AddScores(driver, window));

            // this loop is here to prevent UI freeze. every seconds it returns here and update progress
            while (!scoreTask.IsCompleted)
            {
                await Task.Delay(1000);
                if (!window.IsDisposed && output != "")
                {
                    window.textBox.AppendText(output);
                    output = "";
                }
            }
            if (!window.IsDisposed)
            {
                window.textBox.AppendText("--- PARSOVÁNÍ BYLO ÚSPĚŠNÉ ---" + Environment.NewLine);
            }
            var result = subjects;

            // clear buffers
            subjects = new();
            scoreLinks = new();
            output = "";
            return result;
        }

        private static Task ParseSubject(ChromeDriver driver, IWebElement element, PopupTextWindow window)
        {
            // basic split of data in each cell
            var txt = element.FindElement(By.XPath("td[1]")).Text;
            var lines = txt.Split('\n').Select(line => line.Trim()).ToArray();

            var code = element.FindElement(By.XPath("td[1]/b[1]/a")).Text;
            var name = lines[0].Split(' ', 2)[1];
            output += $"{code}" + Environment.NewLine;
            Lecture lecture = null;

            if (lines.Length == 1) // ¨subject has no seminar nor lecture
            {
                subjects.Add(new Subject(name, code, null, lecture));
                return Task.CompletedTask;
            }

            var hasSeminars = false;
            var linkToSeminars = element.FindElements(By.XPath("td[1]/a")).Last().GetAttribute("href");
            if (linkToSeminars.Contains("seminare"))
            {
                hasSeminars = true;
            }

            if (lines.Length == 3 || (lines.Length == 2 && !hasSeminars)) // subject has lecture
            {
                bool evenWeek = true;
                bool oddWeek = true;
                int day, start, end;
                if (lines[1].Contains("sud"))
                {
                    oddWeek = false;
                    (day, start, end) = ParseDate(lines[1].Substring(lines[1].IndexOf(' ', 12) + 1));

                }
                else if (lines[1].Contains("lich"))
                {
                    evenWeek = false;
                    (day, start, end) = ParseDate(lines[1].Substring(lines[1].IndexOf(' ', 12) + 1));
                }
                else
                {
                    (day, start, end) = ParseDate(lines[1]);
                }

                var room = element.FindElement(By.XPath("td[1]/a[1]")).Text;
                lecture = new Lecture(code, room, day, start, end, evenWeek, oddWeek, "subject");
            }

            if (hasSeminars) // parse seminar group only if it has seminars
            {
                var cookies = driver.Manage().Cookies;
                var seminars = new List<Seminar>();
                subjects.Add(new Subject(name, code, seminars, lecture));
                return Task.Run(() => ParseSeminarGroups(linkToSeminars, cookies, seminars));
            }
            else
            {
                subjects.Add(new Subject(name, code, null, lecture));
                return Task.CompletedTask;
            }                
        }

        /* <link> url in is to seminar's group page of given subject
         * <cookies> cookies used for log in in new driver
         * <seminars> refernce to collection which will be fill in
         */
        private static void ParseSeminarGroups(string link, ICookieJar cookies, List<Seminar> seminars)
        {
            // initialize new ChromeDriver instance
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            options.AddArguments("--headless");
            var driver = new ChromeDriver(chromeDriverService, options);
            driver.Url = "https://is.muni.cz/";
            foreach (var cookie in cookies.AllCookies)
            {
                driver.Manage().Cookies.AddCookie(cookie);
            }
            
            driver.Url = link;

            // iterate and parse through each seminar group
            var tableRows = driver.FindElementsByXPath("/html/body/div[1]/div[2]/div[2]/main/form/table/tbody/tr");
            foreach (var row in tableRows)
            {
                var seminarContent = row.FindElement(By.XPath("td[3]"));
                seminars.Add(ParseSeminar(driver, seminarContent));
            }

            driver.Close();
            driver.Quit();
        }

        private static Seminar ParseSeminar(ChromeDriver driver, IWebElement element)
        {
            var txt = element.FindElement(By.XPath("div")).Text;
            var lines = txt.Split('\n').Select(line => line.Trim()).ToArray();
            string code = element.FindElement(By.XPath("div/h5")).Text;
            output += $"{code}" + Environment.NewLine;

            Lecture lecture = null;
            if (lines[0].Split().Length > 1) // seminar has set lecture
            {
                string room = element.FindElement(By.XPath("div/a[1]")).Text;
                bool evenWeek = true;
                bool oddWeek = true;
                int day, start, end;
                if (lines[0].Contains("sud"))
                {
                    oddWeek = false;
                    (day, start, end) = ParseDate(lines[0].Substring(lines[0].IndexOf(' ', 18) + 1));
                }
                else if (lines[0].Contains("lich"))
                {
                    evenWeek = false;
                    (day, start, end) = ParseDate(lines[0].Substring(lines[0].IndexOf(' ', 18) + 1));
                }
                else
                {
                    (day, start, end) = ParseDate(lines[0].Substring(lines[0].IndexOf(' ') + 1));
                }
                lecture = new Lecture(code, room, day, start, end, evenWeek, oddWeek, "seminar");
            }

            string linkToRegistration = element.FindElement(By.XPath("font/a")).GetAttribute("href");
            var tutors = ParseTutors(driver, element);

            return new Seminar(tutors, code, lecture, linkToRegistration);
        }

        private static List<Tutor> ParseTutors(ChromeDriver driver, IWebElement element)
        {
            var txt = element.FindElement(By.XPath("div")).Text;
            var lines = txt.Split('\n').Select(line => line.Trim()).ToArray();
            
            var tutors = new List<Tutor>();
            var tutorElements = element.FindElements(By.XPath("div/a")).ToList();

            if (lines[0].Split().Length > 1 && lines[0].Contains("rozvrh")) // seminar has no set time
                tutorElements.RemoveRange(0, 2);
            else if (lines[0].Split().Length > 1) // already registered subject
                tutorElements.RemoveRange(0, 1);

            int scoreIndex = 1;
            foreach (var tutorEl in tutorElements)
            {
                var score = new Score(0.0, 0.0, 0.0, 0.0);
                var scoreLink = "";
                var tutorName = tutorEl.Text;
                
                // add score reference with link to buffer, so it can be proccessed later
                if (HasScore(lines[1], tutorName))
                {
                    scoreLink = element.FindElement(By.XPath($"div/span[{scoreIndex}]/a")).GetAttribute("href");
                    scoreLinks.Add((score, scoreLink));
                    scoreIndex++;
                }

                tutors.Add(new Tutor(tutorName, score));
            }

            return tutors;
        }

        private static void AddScores(ChromeDriver driver, PopupTextWindow window)
        {
            int x = 1;
            foreach (var (score, link) in scoreLinks)
            {
                driver.Url = link;

                var name = driver.FindElement(By.XPath("html/body/div[1]/div[2]/div[2]/main/form[2]/table/tbody/tr[1]/td/h3")).Text;
                output += $"{x}. - {name}" + Environment.NewLine;

                double[] scores = new double[4];

                // offset because html structure is different sometimes
                int offset = (driver.FindElements(By.XPath($"html/body/div[1]/div[2]/div[2]/main/form[2]/table/tbody/tr[5]/td/table[1]/tbody/tr[1]/td[1]/table/tbody/tr")).Count == 8) ? 1 : 0;
                int start = 4 + offset;
                int end = 8 + offset;
                for (int i = start; i < end; ++i)
                {
                    var scoreString = driver.FindElement(By.XPath($"html/body/div[1]/div[2]/div[2]/main/form[2]/table/tbody/tr[5]/td/table[1]/tbody/tr[1]/td[1]/table/tbody/tr[{i}]/td[4]")).Text;
                    scores[i - start] = Double.Parse(scoreString, CultureInfo.InvariantCulture);
                }

                score.Explanation = scores[0];
                score.Preparedness = scores[1];
                score.Communication = scores[2];
                score.GreatPedagog = scores[3];
                ++x;
            }
        }


        // SOME HELPER FUCTIONS

        private static (int, int, int) ParseDate(string line)
        {
            string[] content = line.TrimStart().Split();
            var dayStr = content[0];
            string date = line.Contains(',') ? content[3] : content[1];
            int day = DayToInt(dayStr);
            var x = date.Split('–')
                .Select(time => int.Parse(time.Split(':')[0]));
            return (day, x.First(), x.Last());
        }

        private static bool HasScore(string text, string name)
        {
            var i = text.IndexOf(name);
            i += name.Length + 1;
            return text.Substring(i).StartsWith("(hodnocení");
        }

        private static bool AllTasksCompleted(List<Task> tasks)
        {
            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    return false;
                }
            }

            return true;
        }

        private static int DayToInt(string day)
        {
            return day switch
            {
                "Po" => 0,
                "pondělí" => 0,
                "Út" => 1,
                "úterý" => 1,
                "St" => 2,
                "středu" => 2,
                "Čt" => 3,
                "čtvrtek" => 3,
                "Pá" => 4,
                "pátek" => 4,
                _ => -1
            };
        }
    }
}
