using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace petProject; 

// iWebDriver - interface 
// create object of Chrome driver (new ChromeDriver) 

//find 1 element = FindElement(By.XPath("//a/h3)[1]")); 
//


public class GoogleSearchClass
{ 
    [Test]
    public void GoogleSearch() 
    {
        IWebDriver driver = new ChromeDriver(); 
        driver.Navigate().GoToUrl("https://www.google.com/"); 
        driver.Manage().Window.Maximize(); 

        IWebElement txtSearch = driver.FindElement(By.Name("q")); 
        IWebElement acceptCookies = driver.FindElement(By.Id("L2AGLb")); 
        acceptCookies.Click();
        txtSearch.SendKeys("Youtube");
        txtSearch.SendKeys(Keys.Enter); 

    }
}
