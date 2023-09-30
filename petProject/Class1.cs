using System.Linq.Expressions;
using NUnit.Framework;

namespace petProject;

//unit tests (methods) for Calculator
/*add attribute Test (click Alt + Enter after writing [Test]) 
and connect to NUnit (appears using NUnit.Framework;) 
Setup - precondition 
Teardown - postcondition 
OneTimeSetUp / OneTimeTearDown - to do it before/after not all tests, 
but only 1 test  (add method inside it you want to execute */ 


public class Class1 
{ 

    [SetUp]
    public void SetUp() 
    {
        Console.WriteLine("This is setup");
    }  


    [TearDown]
    public void TearDown() 
    {
        Console.WriteLine("This is teardown");
    } 


    [Test]
    public void AddTest() 
    {
        //Arrange (variables)  

        double a=2, b=3;


        //Act (main method, Expected result)  

        double result = Calculator.Add(a, b);


        //Assert (check) Assert is a static class = not create object, call method right from it 

        Assert.AreEqual(a+b, result);

    } 


    [Test]
    public void DivisionTest() 
    {
        //Arrange (variables)  

        double a=4, b=4;


        //Act (main method, Expected result)  

        double result = Calculator.Divide(a, b);


        //Assert (check) Assert is a static class = not create object, call method right from it 

        Assert.AreEqual(a/b, result);

    } 


    [Test]
    public void DivisionTestByZero() 
    { 

        try
        {
        //Arrange (variables)  

        double a=6, b=0;


        //Act (main method, Expected result)  

        //We expect that result will be 0 = catch this DivideByZero and make it Pass 

        //if we catch not DivideByZeroException, but Exception, we will call Assert Fail

        double result = Calculator.Divide(a, b); 

        } 

        catch (DivideByZeroException)
        {
            Assert.Pass("Expected divide by zero expection caught");
        } 

        catch (Exception) 
        {
            Assert.Fail("Wrong exception code");
        }


    
    }

}
