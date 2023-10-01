using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 

using System.Collections.Generic; 
using System.Linq;

namespace petProject;


public class BookingWithWrappings
{ 

  //IWebDriver driver;  
  Driver driver;  

  [SetUp]
  public void Init() 
  {
    driver = new DriverFactory().GetDriverByName("chrome");
    //driver.Navigate().GoToUrl("https://www.booking.com/"); 
    driver.GoToUrl("https://www.booking.com/");
    //driver.Manage().Window.Maximize();
    driver.MaximizeWindow();
  }

  [Test]
  public void Searchcity() 
  {
    //IWebElement acceptCookies = driver.FindElement(By.Id("onetrust-accept-btn-handler"));  
    //IWebElement acceptCookies = driver.FindElementById("onetrust-accept-btn-handler"); 
    Element acceptCookies = driver.FindElementById("onetrust-accept-btn-handler");
    System.Threading.Thread.Sleep(3000);
    acceptCookies.Click(); 

    string city = "Нью-Йорк";
    Element txtDestination = driver.FindElementByXPath("//input[@name='ss']"); 
    txtDestination.Clear(); 
    txtDestination.SendText(city);


    Element btnDate = driver.FindElementByXPath("//button[@data-testid='date-display-field-start']"); 
    btnDate.Click(); 




    //DateTime tomorrow = DateTime.Now.AddDays(1); 
    
    // string checkInYear = tomorrow.Year.ToString(); 
    // string checkInMonth = $"{tomorrow:MMMM}";
    // string checkInDay = tomorrow.Day.ToString(); 

    // DateTime checkOutDate = tomorrow.AddDays(5);  
    // string checkOUtYear = checkOutDate.Year.ToString(); 
    // string checkOutMonth = $"{checkOutDate:MMMM}"; 
    // string checkOutDay = checkOutDate.Day.ToString();


    
    

    //IWebElement firstWindow = driver.FindElement(By.XPath($"//div[@data-testid='searchbox-datepicker-calendar']//h3[text()='{checkInMonth}']"));
    //IWebElement dayToPick = firstWindow.FindElement(By.XPath($".//*[text()='{checkInDay}']")); 

    // IWebElement dayToPick = driver.FindElement(By.XPath($".//*[text()='{checkInDay}']")); 
    // dayToPick.Click(); 


    Element checkInDayToPick = driver.FindElementByXPath("//span[@data-date='2023-10-20']"); 
    checkInDayToPick.Click(); 

    Element checkOutDayToPick = driver.FindElementByXPath("//span[@data-date='2023-10-21']"); 
    checkOutDayToPick.Click();
    

    Element btnSubmit = driver.FindElementByXPath("//button[@type='submit']");
    btnSubmit.Click(); 

    //search common XPath for all cards of hotels 

    List<Element> hotels = driver.FindElementsByXPath("//div[@data-testid='property-card']"); 

    foreach(var hotel in hotels) 
    {
      Element hotelAddress = hotel.FindElementByXpath(".//span[@data-testid='address']");  
      
      //addressing to the element hotelAddress and getting text from it
      string hotelAddressText = hotelAddress.GetText(); 
      StringAssert.Contains(city, hotelAddressText, $"Actual hotel address does not contain {city}"); 
    } 


    string actualDateStart = driver.FindElementByXPath("//button[@data-testid='date-display-field-start']").GetText(); 
    string actualDayStart = actualDateStart.Split(' ')[1]; 
    string actualMonthStart = actualDateStart.Split(' ')[2]; 
    //Assert.AreEqual(checkInDayToPick, actualDayStart, "Check in day is not equal to expected"); 
    




    string actualDateEnd = driver.FindElementByXPath("//button[@data-testid='date-display-field-end']").GetText(); 
    string actualDayEnd = actualDateEnd.Split(' ')[1]; 
    string actualMonthEnd = actualDateEnd.Split(' ')[2]; 
    //Assert.AreEqual(checkOutDayToPick, actualDayEnd, "Check out day is not equal to expected");  
    










    
  } 


//   [TearDown]
//   public void TearDown() 
//   {
//     driver.Close(); 

//     driver.CloseDriver();
//   }


}