using System;

public class PostiveNegative
{
    public void PostiveNegativeMet()
    {
        Console.WriteLine("enter a number:");
        int number=Convert.ToInt32(Console.ReadLine());
        if(number>0)
        {
            Console.WriteLine("positive number");
        }
        else if(number<0)
        {
            Console.WriteLine("negative number");
        }
        else if(number==0)
        {
            Console.WriteLine("number is zero");
        }
        else
        {
            Console.WriteLine("invalid number");
        }
    }
}