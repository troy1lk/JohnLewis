using FluentAssertions;using OpenQA.Selenium;using OpenQA.Selenium.Support.PageObjects;using System.Threading.Tasks;namespace JohnLewis.PAGE{	public class Searchbar	{		public IWebDriver Driver;		public Searchbar(IWebDriver driver)
		{			Driver = driver;			PageFactory.InitElements(Driver, this);		}		public void NavigateMethod()
		{			Driver.Navigate().GoToUrl("https://www.johnlewis.com/");			Task.Delay(2000).Wait();

		}		public void SearchForAnItem()
		{			Driver.FindElement(By.Id("desktopSearch")).SendKeys("laptop");			Driver.FindElement(By.XPath("//div[@class= 'header-search--18002']//*[@id='searchForm']")).Click();			Task.Delay(2000).Wait();

		}		public void VerifySearch()
		{			IWebElement SB = Driver.FindElement(By.XPath("//span[text()='Hide out of stock items']"));			SB.Displayed.Should().BeTrue();			Task.Delay(2000).Wait();		}	}}