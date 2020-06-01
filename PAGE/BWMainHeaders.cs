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
    public class BWMainHeaders
    {
        public IWebDriver Driver;
        public BWMainHeaders(IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateMethod() 
        {
            Driver.Navigate().GoToUrl("https://sports.betway.com/en/sports/cat/esports");
        }
        public void ClickOnHeaders(string link) 
        {
        switch(link)
            {
                case "In-Play":
                    Driver.FindElement(By.CssSelector(".primaryLinks.node > div > div:nth-child(1) > a")).Click();
                    Task.Delay(2000).Wait();
                    break;
                case "horse-racing":
                    Driver.FindElement(By.XPath("//div[contains(text(),'Horse Racing')]")).Click();
                    Task.Delay(2000).Wait();
                    break;
                case "Virtual Sports":
                    Driver.FindElement(By.CssSelector(".grid .categoryList > a:nth-of-type(4) > div > div:nth-of-type(2) > div")).Click();
                    Task.Delay(2000).Wait();
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
                case "In-Play":
                    IWebElement inplay = Driver.FindElement(By.CssSelector(".titleWidgetLayout .title"));
                    inplay.Displayed.Should().BeTrue();
                    Task.Delay(2000).Wait();
                    break;
                case "horse-racing":
                    Driver.FindElement(By.CssSelector(".titleWidgetLayout .title")).Displayed.Should().BeTrue();
                    Task.Delay(2000).Wait();
                    break;
                case "Virtual Sports":
                    Driver.FindElement(By.XPath("//div[text()='Virtual Sports']")).Displayed.Should().BeTrue();
                    Task.Delay(2000).Wait();
                    break;
                default:
                    Console.WriteLine("No such link");
                    break;
            }
        
        }

    }
}
