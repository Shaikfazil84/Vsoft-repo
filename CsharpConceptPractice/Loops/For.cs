using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
public static class Prac
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {

            Console.WriteLine(i);
        }
        // While();
        // DoWhile();
        // Foreach();
        // Sumofeven();
        // UserNoCount();
         Palin pn=new Palin();
         pn.Palindrome();
    }
    //while
    public static void While()
    {
        int i = 2;
        while (i <= 20)
        {
            Console.WriteLine(i);
            i++;
        }
    }
    //DO While
    public static void DoWhile()
    {
        int i = 10;
        do
        {
            Console.WriteLine(i);
        }
        while (i <= 5);
    }
    //foreach
    public static void Foreach()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    //sum of even
    
    public static void Sumofeven(){
int sum = 0;

for (int i = 2; i <= 10; i += 2)
{
    sum += i;
}

Console.WriteLine("Sum = " + sum);
    }
    public static void UserNoCount()
    {
        Console.WriteLine("enter numbers:");
        int n=Convert.ToInt32(Console.ReadLine());
        int count= 0;
        for(int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("even numbers adding"+count);

    }


}   
