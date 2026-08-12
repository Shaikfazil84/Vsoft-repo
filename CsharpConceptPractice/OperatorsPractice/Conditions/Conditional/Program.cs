using System;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    public static void Main(string[] args)
    
    {
        //if statment
        int num = 20;
        if (num > 25)
        {
            Console.WriteLine("yes he is elder");
        }
        //if else
        Console.WriteLine("Enter ur age:");
        int age2 = Convert.ToInt32(Console.ReadLine());
        if (age2>= 18)
        {

            Console.WriteLine("ur eligible");
        }
        else
        {
            Console.WriteLine("ur not eligible");


        }
        Console.WriteLine("enter ur marks:");
        int marks=Convert.ToInt32(Console.ReadLine());
        if(marks>=90)
        {
            Console.WriteLine("ur first grade");
        }
        else if(marks>=70)
        {
            Console.WriteLine("ur second greade");
        }
        else if(marks>=50)
        {
            Console.WriteLine("ur pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }

        Console.WriteLine("Enter a number day no 1-7");
        int Choice1=Convert.ToInt32(Console.ReadLine());
        switch (Choice1)
        {
            case 1:
            Console.WriteLine("sunday");
            break;
            case 2:
            Console.WriteLine("monday");
            break;
            case 3:
            Console.WriteLine("tuesday");
            break;
            case 4:
            Console.WriteLine("wednesday");
            break;
            case 5:
            Console.WriteLine("thrusday");
            break;
            case 6:
            Console.WriteLine("friday");
            break;
             case 7:
            Console.WriteLine("saturday");
            break;
        }

        ATMProject.Run();
        Dict.Display();

        
    }

}

