using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeminarHelper
{
    static class Registrator
    {
        /* For each seminar, register it in certain time.
         * do it in the background or foreground, depending on openWindows argument.
         */
        public static async Task Register(ChromeDriver driver, DateTime date, List<Seminar> seminars, bool openWindows)
        {
            var cookies = driver.Manage().Cookies;
            bool moveUp = true;
            int x = 0;
            int y = 0;
            foreach (var seminar in seminars)
            {
                _ = Task.Run(() => WaitForRefresh(seminar.RegistrationLink, cookies, date, openWindows, x, y));
                await Task.Delay(3000);

                // update coordinates for the next window
                if (moveUp)
                {
                    y += 480;
                }
                else
                {
                    y = 0;
                    x += 480;
                }
                moveUp = !moveUp;
            }
        }


        private static void WaitForRefresh(string link, ICookieJar cookies, DateTime date, bool openWindows, int x, int y)
        {
            // initialize new ChromeDriver instance
            var options = new ChromeOptions();
            if (openWindows)
            {
                options.AddArgument("--window-size=480,480");
            }
            else
            {
                options.AddArguments("--headless");
            }
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            var driver = new ChromeDriver(chromeDriverService, options);
            if (openWindows)
            {
                driver.Manage().Window.Position = new System.Drawing.Point(x, y);
            }
            driver.Url = "https://is.muni.cz/";
            foreach (var cookie in cookies.AllCookies)
            {
                driver.Manage().Cookies.AddCookie(cookie);
            }
            driver.Url = link;

            // put thread to sleep until registration starts
            var now = DateTime.Now;
            var duration = date - now;
            Thread.Sleep((int)duration.TotalMilliseconds);
            // reload page and register that seminar!
            driver.Url = link;

            // close window after one minute and free resources
            Thread.Sleep(60 * 1000);
            driver.Close();
            driver.Quit();
               
        }
    }
}
