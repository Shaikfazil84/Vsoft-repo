using System;
using System.IO.Pipelines;
public class Percentage
{
    public void PercentageMet()
    {
        Console.WriteLine("enter first number:");
        double num1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the second number:");
        double num2=Convert.ToDouble(Console.ReadLine());
        double result=(num1/num2)*100;
        Console.WriteLine($"ur percnatge id:" +result);
    }
}