using System;
using System.ComponentModel;
public static class Prac
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n;i++)
        {
        
            Console.WriteLine(i);
        }
    }
}