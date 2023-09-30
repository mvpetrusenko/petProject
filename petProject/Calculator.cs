namespace petProject;

public static class Calculator
{ 
    public static double Add(double x, double y) 
    {
        return x + y;
    } 

    public static double Remove(double x, double y) 
    {
        return x - y;
    } 

    public static double Multiply(double x, double y) 
    {
        return x * y;
    } 

    public static double Divide(double x, double y) 
    {
        if(y==0) {throw new DivideByZeroException("Can`t divide by 0");}
        return x / y;
    }

}