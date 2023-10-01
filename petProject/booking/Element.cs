//wrapping (for future moving to, for example, Playwrite) 
// {get ...} - property 
//ctor (Tab Tab) - to create a constructor fot the class Driver (parameters) 
//this driver (from driver get set) = driver (from the constructor) 



//wrapping for iWebElement 


using OpenQA.Selenium;

namespace petProject;



public class Element
{ 

  public IWebElement element { get; set; }

  public Element(IWebElement element)
  { 
    this.element = element;
  } 


  public void Click() 
  {
    element.Click();
  }  


  public void Clear() 
  {
    element.Clear();
  }  


   public void SendText(string text) 
  {
    element.SendKeys(text);
  } 


  public Element FindElementByXpath(string xpath) 
  {
    return new Element(element.FindElement(By.XPath(xpath)));
  }
 

 // public string - method which returns a string 

 public string GetText() 
 {
    return element.Text;
 }



}