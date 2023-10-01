using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 

using System.Collections.Generic; 
using System.Linq;

namespace petProject;

//

public class Booking
{ 

  IWebDriver driver;  

  [SetUp]
  public void Init() 
  {
    driver = new ChromeDriver(); 
    driver.Navigate().GoToUrl("https://www.booking.com/"); 
    driver.Manage().Window.Maximize();
  }

  [Test]
  public void Searchcity() 
  {
    IWebElement acceptCookies = driver.FindElement(By.Id("onetrust-accept-btn-handler")); 
    System.Threading.Thread.Sleep(3000);
    acceptCookies.Click(); 

    string city = "Нью-Йорк";
    IWebElement txtDestination = driver.FindElement(By.XPath("//input[@name='ss']")); 
    txtDestination.Clear(); 
    txtDestination.SendKeys(city);


    IWebElement btnDate = driver.FindElement(By.XPath("//button[@data-testid='date-display-field-start']")); 
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


    IWebElement checkInDayToPick = driver.FindElement(By.XPath("//span[@data-date='2023-10-20']")); 
    checkInDayToPick.Click(); 

    IWebElement checkOutDayToPick = driver.FindElement(By.XPath("//span[@data-date='2023-10-21']")); 
    checkOutDayToPick.Click();
    

    IWebElement btnSubmit = driver.FindElement(By.XPath("//button[@type='submit']"));
    btnSubmit.Click(); 

    //search common XPath for all cards of hotels 

    List<IWebElement> hotels = driver.FindElements(By.XPath("//div[@data-testid='property-card']")).ToList(); 

    foreach(var hotel in hotels) 
    {
      IWebElement hotelAddress = hotel.FindElement(By.XPath(".//span[@data-testid='address']"));  
      
      //addressing to the element hotelAddress and getting text from it
      string hotelAddressText = hotelAddress.Text; 
      StringAssert.Contains(city, hotelAddressText, $"Actual hotel address does not contain {city}"); 
    } 


    string actualDateStart = driver.FindElement(By.XPath("//button[@data-testid='date-display-field-start']")).Text; 
    string actualDayStart = actualDateStart.Split(' ')[1]; 
    string actualMonthStart = actualDateStart.Split(' ')[2]; 
    //Assert.AreEqual(checkInDayToPick, actualDayStart, "Check in day is not equal to expected"); 
    




    string actualDateEnd = driver.FindElement(By.XPath("//button[@data-testid='date-display-field-end']")).Text; 
    string actualDayEnd = actualDateEnd.Split(' ')[1]; 
    string actualMonthEnd = actualDateEnd.Split(' ')[2]; 
    //Assert.AreEqual(checkOutDayToPick, actualDayEnd, "Check out day is not equal to expected");  
    










    
  } 


//   [TearDown]
//   public void TearDown() 
//   {
//     driver.Close();
//   }


}