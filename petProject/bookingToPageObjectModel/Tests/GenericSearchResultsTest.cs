using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 

using System.Collections.Generic; 
using System.Linq;

namespace petProject;


//GenericSearchResultTest is inheritid from BaseTest

public class GenericSearchResultTest : BaseTest 
{ 


  [Test]
  public void Searchcity() 
  {
    //IWebElement acceptCookies = driver.FindElement(By.Id("onetrust-accept-btn-handler"));  
    //IWebElement acceptCookies = driver.FindElementById("onetrust-accept-btn-handler"); 
    Element acceptCookies = driver.FindElementById("onetrust-accept-btn-handler");
    System.Threading.Thread.Sleep(3000);
    acceptCookies.Click();  


    InitialPage.FillDestination(city); 

    InitialPage.ClickDate(); 



    InitialPage.PickDates();



    

    //Element btnSubmit = driver.FindElementByXPath("//button[@type='submit']");
    //btnSubmit.Click(); 



    string actualDateStart = driver.FindElementByXPath("//button[@data-testid='date-display-field-start']").GetText(); 
    string actualDayStart = actualDateStart.Split(' ')[1]; 
    string actualMonthStart = actualDateStart.Split(' ')[2]; 
    //Assert.AreEqual(checkInDayToPick, actualDayStart, "Check in day is not equal to expected"); 
    




    string actualDateEnd = driver.FindElementByXPath("//button[@data-testid='date-display-field-end']").GetText(); 
    string actualDayEnd = actualDateEnd.Split(' ')[1]; 
    string actualMonthEnd = actualDateEnd.Split(' ')[2]; 
    //Assert.AreEqual(checkOutDayToPick, actualDayEnd, "Check out day is not equal to expected");  
    
  }


}