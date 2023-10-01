using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace petProject;




public class DriverFactory
{  

    //method which returns Driver 
    //method GetDriverByName accepts string browserName 

    //add Nuget package Selenium.Firefox.Webdriver

    public Driver GetDriverByName(string browserName) 
    {
        IWebDriver driver; 

        switch(browserName) 
        {
            case "chrome": 
                driver = new ChromeDriver(); 
                break;
            case "firefox": 
                driver = new FirefoxDriver(); 
                break; 

            //headless browser - quicker, without GUI 
            case "headless": 
                ChromeOptions options = new ChromeOptions(); 
                options.AddArguments("--headless"); 
                driver = new ChromeDriver(options);
                break;  
            default: 
                throw new Exception("You selected a wrong browser");
        } 

        return new Driver(driver);
    }

  

}