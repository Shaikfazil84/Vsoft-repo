using System;
public class EvenOdd
{
    public void EvenOddMet()
    {
        Console.WriteLine("enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("even number");
        }
        else
        {
            Console.WriteLine("odd number");
        }
    }

}
