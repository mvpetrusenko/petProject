namespace petProject;




public class BasePage
{ 

  protected static Driver driver;  

  public BasePage(Driver webdriver)
  {
    driver = webdriver;
  }

}