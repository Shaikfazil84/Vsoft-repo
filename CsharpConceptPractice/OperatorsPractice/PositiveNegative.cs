using System;

public class PostiveNegative
{
    int number;

    public PostiveNegative()
    {
        
    }
    public PostiveNegative(int num)
    {
        this.number = num;
    }
    public void PostiveNegativeMet()
    {
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

    public string PostiveNegativeMet(int number)
    {
        string message = "";
        if(number>0)
        {
            message = "positive number";
        }
        else if(number<0)
        {
            message = "negative number";
        }
        else if(number==0)
        {
             message = "number is zero";
        }
        else
        {
            message = "invalid number";
        }
        return message;
    }
}