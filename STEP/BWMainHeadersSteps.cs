using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using JohnLewis.BASE;
using JohnLewis.PAGE;

namespace JohnLewis.STEP
{
    [Binding]
    [Scope(Tag = "@bwmainheaders")]
    public class BWMainHeadersSteps : Hooks
    {
        public IWebDriver driver;
        public BWMainHeaders browser;

        [Given(@"I navigate to betway essports")]
        public void GivenINavigateToBetwayEssports()
        {
            driver = Driver;
            browser = new BWMainHeaders(driver);
            browser.NavigateMethod();
        }
        
        [When(@"I click on (.*)")]
        public void WhenIClickOnIn_Play(string link)
        {
            browser.ClickOnHeaders(link);
        }
        
        [Then(@"I see the (.*) page")]
        public void ThenISeeTheIn_PlayPage(string link)
        {
            browser.VerifyHeaders(link);
        }
    }
}
