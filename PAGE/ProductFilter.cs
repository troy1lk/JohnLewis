using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;

namespace JohnLewis.PAGE
{
   public class ProductFilter
    {
        public IWebDriver Driver;
        public ProductFilter (IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

      
        public void NavigateMethod() 
        {      
            Driver.Navigate().GoToUrl("https://www.johnlewis.com/");
            Task.Delay(3000).Wait();


        }
        public void SearchForCamers() 
        {    
            Driver.FindElement(By.Id("desktopSearch")).SendKeys("camera");
            Driver.FindElement(By.XPath("//div[@class= 'header-search--18002']//*[@id='searchForm']")).Click();
            Task.Delay(2000).Wait();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, 300)");
            Task.Delay(3000).Wait();
        }

        public void TopListed() 
        {
            Driver.FindElement(By.CssSelector(".slider-toggle")).Click();
            Task.Delay(4000).Wait();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, 300)");
            Task.Delay(3000).Wait();

            Driver.FindElement(By.CssSelector("#product-sort")).Click();
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//section[@class='faceted-filters-section faceted-filters-section--singles']//a[contains(text(),'New In')]")).Click();
            Task.Delay(3000).Wait();
            Driver.FindElement(By.PartialLinkText("£1540 - £15")).Click();
            Task.Delay(3000).Wait();
            Driver.FindElement(By.PartialLinkText("Next Day Delive")).Click();
            Task.Delay(3000).Wait();

            Screenshot TopListed = ((ITakesScreenshot)Driver).GetScreenshot();
            TopListed.SaveAsFile(@"C:\Users\troy1\source\repos\JohnLewis\SS\TopListed.Jpeg", ScreenshotImageFormat.Jpeg);

            Driver.FindElement(By.XPath("//body/main/div/div/div/div/div/a[4]")).Click(); //Clear Filters
            Task.Delay(3000).Wait();

           

        }

        public void BottomListed()
        {
          
            Driver.FindElement(By.XPath("//div[@class= 'header-search--18002']//*[@id='searchForm']")).Click();
            Task.Delay(2000).Wait();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, 300)");
            Task.Delay(3000).Wait();
            Driver.FindElement(By.Id("product-sort")).Click();
            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("#product-sort > option:nth-of-type(7)")).Click(); //discount hi to low
            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector(".faceted-filters-section--singles .faceted-filters-section-list > li:nth-of-type(2) > a")).Click();
            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("#accordion-0 .faceted-filters-section-list > li:nth-of-type(4)>a")).Click();
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//a[contains(text(),'£80 - £90')]")).Click();
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//a[contains(text(),'Next Day Delivery')]")).Click();
            Task.Delay(3000).Wait();

            Screenshot BotListed = ((ITakesScreenshot)Driver).GetScreenshot();
            BotListed.SaveAsFile(@"C:\Users\troy1\source\repos\JohnLewis\SS\BotListed.Jpeg", ScreenshotImageFormat.Jpeg);
        }

        public void MidListed()
        {
            Driver.FindElement(By.CssSelector(".product-list-faceted-filters__inner > div:nth-of-type(2) > div > a:nth-of-type(5)")).Click();
            Task.Delay(2000).Wait();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, 300)");
            Task.Delay(3000).Wait();

            Driver.FindElement(By.Id("product-sort")).Click();
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//option[contains(text(),'Newness')]")).Click(); //newness
            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector(".faceted-filters-section--singles .faceted-filters-section-list > li:nth-of-type(2) > a")).Click(); //exclisive
            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("#accordion-0 .faceted-filters-section-list > li:nth-of-type(2) > a")).Click(); //compact sys
          
            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("#accordion-1 .faceted-filters-section-list > li:nth-of-type(3) > a")).Click(); //Olympus
            Task.Delay(3000).Wait();
            Driver.FindElement(By.CssSelector("#accordion-2 .faceted-filters-section-list-link")).Click(); //490-500
            Task.Delay(3000).Wait();         

        }

        public void MixListed()
        {
            Driver.FindElement(By.CssSelector(".product-list-faceted-filters__inner > div:nth-of-type(2) > div > a:nth-of-type(5)")).Click(); //clear all filters
            Task.Delay(3000).Wait();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, 300)");
            Task.Delay(3000).Wait();

            Driver.FindElement(By.CssSelector(".slider-toggle")).Click();
            Task.Delay(4000).Wait();

            Driver.FindElement(By.Id("product-sort")).Click();
            Task.Delay(3000).Wait();

            Driver.FindElement(By.XPath("//option[text()='Popularity']")).Click(); //popularity
            Task.Delay(3000).Wait();

            Driver.FindElement(By.CssSelector(".faceted-filters-section--singles .faceted-filters-section-list > li:nth-of-type(2) > a")).Click(); //exclisive
            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//a[contains(text(),'Bridge')]")).Click(); //bridge

     

            Task.Delay(3000).Wait();
            Driver.FindElement(By.XPath("//a[contains(text(),'£690 - £700')]")).Click(); //690-700
            Task.Delay(3000).Wait();

            Driver.FindElement(By.XPath("//a[contains(text(),'Click & Collect')]")).Click(); //click n collect
            Task.Delay(3000).Wait();

        }



       
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     

        public void VerifyFisrtListed()
        {
          IWebElement FL = Driver.FindElement(By.CssSelector(".product-list-heading"));
            FL.Displayed.Should().BeTrue();
            Task.Delay(4000).Wait();      
        }

        public void VerifyBottomListed()
        {
            Driver.FindElement(By.Id("product-sort")).Displayed.Should().BeTrue(); //HARD-CODED
            Task.Delay(4000).Wait();
        }

        public void VerifyMidListed()
        {
            Driver.FindElement(By.CssSelector(".product-list-heading")).Displayed.Should().BeTrue();//HARD-CODED
            Task.Delay(4000).Wait();
        }

        public void VerifyMixListed()
        {
            IWebElement ML = Driver.FindElement(By.ClassName("nku-cta"));
            ML.Displayed.Should().BeTrue();
            Task.Delay(4000).Wait();

        }
    }
}



    