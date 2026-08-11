using System;

public class LargestofTwo
{
    public void LargestofTwoMet()
    {
        Console.WriteLine("enter first number:");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter a second number");
        int num2=Convert.ToInt32(Console.ReadLine());

    if(num1>num2)
    {
        Console.WriteLine("num1 is larger than num2");
    }
        else
        {
            Console.WriteLine("num2 is larger tahn num1");
        }
    }
}
