using NUnit.Framework; 

namespace petProject;



//class example 

public class BaseTest
{ 
 
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

  //   [TearDown]
//   public void TearDown() 
//   {

//     driver.CloseDriver();
//   }

}