using System;
namespace practiceprom
{
    public class Operators
    {
        public void OperatorsMet()
        {
            int a = 20;
            int b = 30;
            int c = 40;
            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {c - a}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {c / b}");
            Console.WriteLine($"Modulus: {c % a}");
        }
    }
    public class ChangeOperator
    {
        public void ChangeOperatorMet()
        {
            int a = 33;
            int b = 46;
            int c=55;
            Console.WriteLine("Before changing: " + a);
            a = 22;
            Console.WriteLine("After changing: " + a);
            if (a == 22)
            {
                Console.WriteLine(a + " is equal to 22");
            }
            //comparison operators
            if (a != b)
            {
                Console.WriteLine(a + " is not equal to " + b);
            }
            Console.WriteLine($"greater than: {a>b}");
            Console.WriteLine($"less than: {a<b}");
            Console.WriteLine($"greater than or equal to: {a>=c}");
            Console.WriteLine($"less than or equal to: {a<=c}");
            Console.WriteLine($"equal to: {a==c}");

        }
    }
    public class LogicalOperator
    {
        public void LogicalOperatorMet()
        {
            int age=20;
            int age1=33;
            if(age>18 && age1<30)
            {
                Console.WriteLine("both condionds are true:");
            }
            else
            {
                Console.WriteLine("Conaditions are not true");
            }
            if(age>=18 || age1<30)
            {
                Console.WriteLine("one of the conditions is true");
            }
            else
            {
                Console.WriteLine("both conditions are false");
            }
            if(!(age>18))
            {
                Console.WriteLine("condition is false");
            }
            else
            {
                Console.WriteLine("condition is true");
            }

        }
    }
    public class IncrementDecrement
    {
        public void IncrementDecrementMet()
        {
            int a=10;
            a++;
            Console.WriteLine("increment: " + a);
            a--;
            Console.WriteLine("decrement: " + a);

        }
    }
    //even odd 
    public class EvenOdd
    {
        public void EvenOddMet()
        {
            Console.WriteLine("Enter a number: ");
            int number=Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }

        }
    }

}