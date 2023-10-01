//wrapping (for future moving to, for example, Playwrite) 
// {get ...} - property 
//ctor (Tab Tab) - to create a constructor fot the class Driver (parameters) 
//this driver (from driver get set) = driver (from the constructor)

using OpenQA.Selenium;

namespace petProject;



public class Driver
{ 

  public IWebDriver driver { get; set; } 

  public Driver(IWebDriver driver)
  {
    this.driver = driver;
  } 

  //method for driver.Navigate.ToUrl 

  public void GoToUrl(string url) 
  {
    //driver.Navigate().GoToUrl("https://www.booking.com/"); 
    driver.Navigate().GoToUrl(url); 
  } 

   public void MaximizeWindow() 
  {
    driver.Manage().Window.Maximize();
  } 

// method FindElementByXpath not void, because it returns web element
  public Element FindElementByXPath(string XPath) 
  {
    return new Element (driver.FindElement(By.XPath(XPath)));
  }  

  public List<Element> FindElementsByXPath(string XPath) 
  {
    var elements = driver.FindElements(By.XPath(XPath)); 
    //var result change all elements to new Element
    var result = elements.Select(x => new Element(x));
    return result.ToList();
  } 

  public Element FindElementById(string Id) 
  {
    return new Element (driver.FindElement(By.XPath(Id)));
  }  

  public void CloseDriver() 
  {
    driver.Close();
  } 

}