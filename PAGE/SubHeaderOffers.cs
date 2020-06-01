using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FluentAssertions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;


namespace JohnLewis.PAGE
{
    public class SubHeaderOffers
    {
        public IWebDriver Driver;
        public SubHeaderOffers (IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void NavigateMethod() 
        {
            Driver.Navigate().GoToUrl("https://www.johnlewis.com/");
            Task.Delay(4000).Wait();
           
        }

        public void CouserMoveToOffers()
        {
            new Actions(Driver).MoveToElement(Driver.FindElement(By.XPath("//body/div[@id='root']/header/nav/ul/li[1]/a[1]"))).Build().Perform();
            Task.Delay(2000).Wait();        
        }

        public void ClickSubHeaders(string link) 
        {
        switch(link)
            {
                case "Womenswear Offers":                                     
                    Task.Delay(2000).Wait();
                    Driver.FindElement(By.XPath("//a[@class='secondary-link-link--9fe4a secondary-link-link--secondary--d1f71'] [text()='Womenswear Offers']")).Click();
                    Task.Delay(2000).Wait();               
                    break;
                case "20% off Men's Shoes":
                    Driver.FindElement(By.CssSelector("body.categories-page-body.jl-focusmanager-hide.js-focus-visible:nth-child(2) header.header-siteWide--2450f nav.desktop-nav-nav-lrg-screen--462d4 ul.primary-link-list-list--b3ea2 li.primary-link-list-item--23ac8:nth-child(1) div.category-list-wrapper--d0494 div.category-list-container--62727 ul.category-list-links--776a4 li.category-nav-lrg-secondary-cat--5236a:nth-child(2) div.category-nav-lrg-secondary-list-wrapper--7ada9 ul.link-list-list--b26ee.secondary-link-list-nav-lrg-secondary-list--b9439 li.secondary-link-item--83dd5:nth-child(3) > a.secondary-link-link--9fe4a.secondary-link-link--secondary--d1f71")).Click(); //50% off hobbs

                    Task.Delay(4000).Wait();
                    break;
                case "3 year guaranteee on selected Windows laptops over £499":
                    Driver.FindElement(By.XPath("//a[contains(text(),'3 year guaranteee on selected Windows laptops over')]")).Click();
                    Task.Delay(4000).Wait();
                    break;
                default:
                    Console.WriteLine("No such link");
                    break;
            }
        }
        public void VerifySubHeaders(string link)
        {
            switch (link)
            {
                case "Womenswear Offers":
                    Driver.FindElement(By.XPath("//h1[text()='Womenswear Offers']")).Click();
                    Task.Delay(2000).Wait();
                    break;
                case "20% off Men's Shoes":
                    Driver.FindElement(By.ClassName("product-list-heading")).Click();
                    Task.Delay(2000).Wait();
                    break;
                case "3 year guaranteee on selected Windows laptops over £499":
                    Driver.FindElement(By.XPath("//h1[contains(text(),'View All Laptops & MacBooks')]")).Click();
                    Task.Delay(2000).Wait();
                    break;
                default:
                    Console.WriteLine("No such link");
                    break;
            }
        }

    }
}
