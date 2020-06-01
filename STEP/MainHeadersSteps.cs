using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using JohnLewis.BASE;
using JohnLewis.PAGE;

namespace JohnLewis.STEP
{
    [Binding]
    [Scope(Tag = "mainheaders")]
    public class MainHeadersSteps : Hooks
    {
        public IWebDriver driver;
        public MainHeaders browser;

        [Given(@"I navigato to JohnLewis")]
        public void GivenINavigatoToJohnLewis()
        {
            driver = Driver;
            browser = new MainHeaders(driver);
            browser.NavigateMethod();
        }
        
        [When(@"I click on (.*)")]
        public void WhenIClickOnOffers(string link)
        {
            browser.ClickOnHeaders(link);
        }
        
        [Then(@"I see the (.*) page")]
        public void ThenISeeTheOffersPage(string link)
        {
            browser.VerifyHeaders(link);
        }
    }
}
