using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SeminarHelper
{
    class Logger
    {
        ChromeDriver driver;
        public Logger(ChromeDriver driver)
        {
            this.driver = driver;
            driver.Url = "https://muni.islogin.cz/login/OMmKoTiUrcF3n_HGfENB5e4W";
        }

        public bool Log(string name, string password)
        {
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/main/div/div/form/div[1]/div/div/span[1]/input")).SendKeys(name);
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/main/div/div/form/div[1]/div/div/span[3]/input")).SendKeys(password + OpenQA.Selenium.Keys.Enter);
            return !driver.Url.StartsWith("https://muni.islogin.cz/login");
        }
    }
}
