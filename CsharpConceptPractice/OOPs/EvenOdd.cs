using System;
using System.ComponentModel.DataAnnotations;

public class ReverseArray
{
    public void Reverse()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        foreach (int number in numbers)
        {


            if (number % 2 == 0)
            {
                Console.Write(number);

            }
            if (number > 0)
            {

                Console.Write(",");
            }

        }
    }
}

