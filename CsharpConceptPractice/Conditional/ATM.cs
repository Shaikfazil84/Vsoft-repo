using System;
using System.Collections;
public static class ATMProject
{
    public static void Run()
    {
        int pin = 1234;
        double balance = 10000;
        Console.WriteLine("===ATM====");
        Console.WriteLine("Enetr pin:");
        int enterpin = Convert.ToInt32(Console.ReadLine());
        if (enterpin == pin)
        {
            Console.WriteLine("Login Successful!");
            Console.WriteLine("=Menu=");
            Console.WriteLine("1.Check Blance");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("Exist");

            Console.WriteLine("Enter a choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            //Switch
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your balance :" + balance);
                    break;
                case 2:
                    Console.WriteLine("enter ur deposit:");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    if (deposit > 0)
                    {
                        balance = balance + deposit;
                        Console.WriteLine("Despoit Succesful");
                        Console.WriteLine("updated balnce:" + balance);

                    }
                    else
                    {
                        Console.WriteLine("invalid deposit amount!");
                    }
                    break;
                case 3:
                    Console.WriteLine("Withdraw Amount:");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    if (withdraw > 0)
                    {
                        balance=balance-withdraw;
                        Console.WriteLine("Withdraw successfully");
                        Console.WriteLine("Reaminig balance:" + withdraw);
                    }
                    else
                    {
                        Console.WriteLine("insufficent balnce");
                    }
                    break;
                case 4:
                    Console.WriteLine("thank for using ATM");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;


            }
        }
        else
        {
            Console.WriteLine("invalid Pin");
        }
    }
}