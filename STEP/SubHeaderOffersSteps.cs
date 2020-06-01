using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using JohnLewis.BASE;
using JohnLewis.PAGE;

namespace JohnLewis.STEP
{
    [Binding]
    [Scope(Tag = "subheaderoffers")]
    public class SubHeaderOffersSteps : Hooks
    {
        public IWebDriver driver;
        public SubHeaderOffers browser;

        [Given(@"I navigate to johnlewis")]
        public void GivenINavigateToJohnlewis()
        {
            driver = Driver;
            browser = new SubHeaderOffers(driver);
            browser.NavigateMethod();       
        }

        [Given(@"I move the cousor to offers")]
        public void GivenIMoveTheCousorToOffers()
        {
            browser.CouserMoveToOffers();
        }

        [When(@"I click on (.*)")]
        public void ThenISeeTheWomenswearOffersPage (string link)   
        {
            browser.VerifySubHeaders(link);
        }

        [Then(@"I see the (.*) page")]
        public void WhenIClickOnSubWomenswearOffers (string link)
        {
            browser.ClickSubHeaders(link);
        }
    }
}
