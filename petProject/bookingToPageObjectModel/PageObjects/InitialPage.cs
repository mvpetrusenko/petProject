namespace petProject;




public class InitialPage : BasePage
{ 

// inherited with base constructor
  public InitialPage(Driver driver) : base(driver)
  {
    string city = "Нью-Йорк";
    private Element txtDestination => driver.FindElementByXPath("//input[@name='ss']"); 
    


    public void FillDestination(string city) 
    {
        txtDestination.Clear(); 
        txtDestination.SendText(city); 
    } 

    private Element GetBtnDate() 
    {
        Element btnDate = driver.FindElementByXPath("//button[@data-testid='date-display-field-start']"); 
    
        return btnDate;
    } 


    public void ClickDate() 
    {
        GetBtnDate().Click();
    } 

    public Element PickDates() 
    {
        Element checkInDayToPick = driver.FindElementByXPath("//span[@data-date='2023-10-20']"); 
        checkInDayToPick.Click(); 

        Element checkOutDayToPick = driver.FindElementByXPath("//span[@data-date='2023-10-21']"); 
        checkOutDayToPick.Click(); 

        return checkInDayToPick; 
        return checkOutDayToPick
    }
    
  }

}