using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JohnLewis.BASE
{
    public class Hooks
    {
        public IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Window.FullScreen();
            Driver.Manage().Cookies.DeleteAllCookies();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Close();
            Driver.Quit();
        }
    }
}
