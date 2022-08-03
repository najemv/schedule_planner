using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeminarHelper
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // disable Selenium Console
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            // hide browser window
            var options = new ChromeOptions();
            options.AddArguments("--headless");

            var driver = new ChromeDriver(chromeDriverService, options);

            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            // show new form where user has to login to IS

            // run the main window
            System.Windows.Forms.Application.Run(new Application(driver));

            driver.Close();
            driver.Quit();
        }


    }
}
