using System;
using System.ComponentModel;
public class Palin
{
    public void Palindrome()
    {
        Console.WriteLine("enter a number:");
        int num=Convert.ToInt32(Console.ReadLine());
        int original =num;
        int reverse=0;
        while (num > 0)
        {
            int digit =num%10;
            reverse=reverse*10+digit;
            num=num/10;
        }
        if (reverse == original)
        {
            Console.WriteLine("palindrome");
        }
        else
        {
            Console.WriteLine("not palindrome");
        }
    }
}