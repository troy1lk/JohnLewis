using System;
using TechTalk.SpecFlow;
using JohnLewis.BASE;
using JohnLewis.PAGE;
using OpenQA.Selenium;

namespace JohnLewis.STEP
{
    [Binding]
    [Scope(Tag = "searchbar")]
    public class SearchbarSteps : Hooks
    {
        public IWebDriver driver;
        public Searchbar browser;

        [Given(@"I navigate to johnlewis")]
        public void GivenINavigateToJohnlewis()
        {
            driver = Driver;
            browser = new Searchbar(driver);
            browser.NavigateMethod();
        }
        
        [When(@"I search for an item using searchbar")]
        public void WhenISearchForAnItemUsingSearchbar()
        {
            browser.SearchForAnItem();
        }
        
        [Then(@"I see the search results")]
        public void ThenISeeTheSearchResults()
        {
            browser.VerifySearch();
        }
    }
}
