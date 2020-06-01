using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace JohnLewis.PAGE
{
    public class MainHeaders
    {
        public IWebDriver Driver;
        public MainHeaders(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void NavigateMethod()
        {
            Driver.Navigate().GoToUrl("https://www.johnlewis.com/");
        }

        public void ClickOnHeaders(string link)
        {
            switch (link)
            {
                case "offers":
                    Driver.FindElement(By.XPath("//body/div[@id='root']/header/nav/ul/li[1]/a[1]")).Click();
                    Task.Delay(4000).Wait();
                    break;
                    
                case "electricals":
                    Driver.FindElement(By.XPath("//a[@href='/electricals/c500001'] [@class='primary-link-link--40b4e primary-link-primary--47562']")).Click();
                    Task.Delay(3000).Wait();
                    break;
                case "gifts":
                    Driver.FindElement(By.XPath("//nav[@class='desktop-nav-nav-lrg-screen--462d4']//a[@href='/gifts/c500009'] [text()='Gifts']")).Click();
                    Task.Delay(3000).Wait();
                    break;
                default:
                    Console.WriteLine("No such link");
                    break;
            }

        }
        public void VerifyHeaders(string link)
        {
            switch (link)
            {
                case "offers":
                    IWebElement off = Driver.FindElement(By.XPath("//h1[text()='Offers']"));
                    off.Displayed.Should().BeTrue();
                    Task.Delay(4000).Wait();
                    break;

                case "electricals":
                    Driver.FindElement(By.ClassName("product-list-heading")).Displayed.Should().BeTrue(); //HARD-CODED
                    Task.Delay(3000).Wait();
                    break;
                case "gifts":
                    Driver.FindElement(By.XPath("//h1[text()='Gifts']")).Displayed.Should().BeTrue(); //HARD-CODED
                    Task.Delay(3000).Wait();
                    break;
                default:
                    Console.WriteLine("No such link");
                    break;
            }
        }

    }
}
