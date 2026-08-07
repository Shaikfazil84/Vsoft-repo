using System;
namespace practiceprom
{
    class Program
    {
        const string College="ABs College";
        static void Main(string[] args)
        {
            Console.WriteLine("====Student information====");
            string name;
            int age;
            double marks;
            char grade;
            bool isPassed;
            Console.WriteLine("Enter your name:");
            name=Console.ReadLine()?? "";
            Console.WriteLine("Enter your age:");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your marks:");
            marks=Convert.ToDouble(Console.ReadLine());
            if(marks>=80)
            {
                isPassed = true;
                grade='A';

            }
            else if(marks>=70)
            {
                isPassed=true;
                grade = 'B';
            
            }
            else if(marks>=60)
            {
                isPassed=true;
                grade='C';
            }
            else if(marks>=50)
                {
                    isPassed=true;
                    grade='D';
                }
             else
                {
                    isPassed=false;
                    grade='F';
                }
            Console.WriteLine();
            Console.WriteLine("----Student Details----");
            Console.WriteLine("College:"+College);
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Age:"+age);
            Console.WriteLine("Marks:"+marks);
            Console.WriteLine("Grade:"+grade);
            Console.WriteLine("Passed:"+isPassed);


            int a=10;
            int b=30;
            Console.WriteLine();
            Console.WriteLine("Arithematic Opertions");
            Console.WriteLine("Addition:"+(a+b));
            Console.WriteLine("Subtraction:"+(a-b));
            Console.WriteLine("Multipliacation:"+(a*b));
            Console.WriteLine("Divisin:"+(a/b));
            Console.WriteLine("Modulus:"+(a%b));

            Console.WriteLine();
            Console.WriteLine("Comparison opertions");
            Console.WriteLine(a>b);
            Console.WriteLine(a<b);
            Console.WriteLine(a>=b);
            Console.WriteLine(a<=b);
            Console.WriteLine(a==b);
            Console.WriteLine(a!=b);

            Console.WriteLine();
            Console.WriteLine("Logical opertions");
            Console.WriteLine(age>18 && marks>50);
            Console.WriteLine(age>18 || marks>50);
            Console.WriteLine(!isPassed);

            Console.WriteLine();
            Console.WriteLine("Enter s number(1-3):");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                Console.WriteLine("You selected option 1");
                break;
                case 2:
                Console.WriteLine("You selected option 2");
                break;
                case 3:
                Console.WriteLine("You selected option 3");
                break;
                default:
                Console.WriteLine("Invalid options");
                break;
            }
            Console.WriteLine();
            Console.WriteLine("for loop");
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("while loop");

            int count=1;
            while(count<=5)
            {
                Console.WriteLine(count);
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("Array Example");
            int[] numbers={10,22,33,44,55};
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            name=Console.ReadLine()?? "";

            int total =Add(100,300);
            Console.WriteLine("sum=" + total);
            Console.WriteLine();
            Console.WriteLine("Program finished");
        }
        static void Greet(string studentName)
        {
            string message="welcome"+studentName;
            Console.WriteLine(message);
        }
        static int Add(int x,int y)
        {
            int result=x+y;
            return result;
        }
    }
}