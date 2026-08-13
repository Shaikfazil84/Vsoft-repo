using System;
using System.Diagnostics;
public class Incre
{
    public void Increm()
    {
        Console.WriteLine("enter the number:");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<=num;i++)
        {
            Console.WriteLine(i);
        }
    }
}