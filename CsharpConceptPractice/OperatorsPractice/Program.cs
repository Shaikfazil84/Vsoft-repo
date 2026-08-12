using System;
class Program1
{
    public static void Main(string[] args)
    {
        EvenOdd eo=new EvenOdd();
        eo.EvenOddMet();

        Console.WriteLine("enter a number:");
        int number=Convert.ToInt32(Console.ReadLine());

        PostiveNegative pn= new PostiveNegative();
        string message = pn.PostiveNegativeMet(number);
        Console.WriteLine("output", message);

        PostiveNegative pn1= new PostiveNegative(number);
        pn1.PostiveNegativeMet();

        LargestofTwo lot =new LargestofTwo();
        lot.LargestofTwoMet();
        Percentage per=new Percentage();
        per.PercentageMet();
        Swaping sp=new Swaping();
        sp.SwapingMet();
    }
}
