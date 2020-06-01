using System;
using TechTalk.SpecFlow;
using JohnLewis.BASE;
using JohnLewis.PAGE;
using OpenQA.Selenium;

namespace JohnLewis.STEP
{
    [Binding]
    [Scope(Tag = "productfilter")]
    public class ProductFilterSteps : Hooks
    {
        public IWebDriver driver;
        public ProductFilter browser;

        [Given(@"I navigate to johnlewis")]
        public void GivenINavigateToJohnlewis()
        {
            driver = Driver;
            browser = new ProductFilter(driver);
            browser.NavigateMethod();
        }
        
        [Given(@"I search for cameras")]
        public void GivenISearchForCameras()
        {
            browser.SearchForCamers();
        }
        
        [When(@"I select the filter options")]
        public void WhenISelectTheFilterOptions()
        {
            browser.TopListed();
            browser.BottomListed();
            browser.MidListed();
            browser.MixListed();
        }
        
        [Then(@"I see the filtered results")]
        public void ThenISeeTheFilteredResults()
        {
            browser.VerifyFisrtListed();
            browser.VerifyBottomListed();
            browser.VerifyMidListed();
            browser.VerifyMixListed();
        }
    }
}
