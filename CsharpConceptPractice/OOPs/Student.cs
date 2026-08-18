using System;

public class Student
{
    // Fields
    public string name;
    public int age;
    public int marks1;
    public int marks2;
    public int marks3;

    // Constructor
    public Student(string studentName, int studentAge)
    {
        name = studentName;
        age = studentAge;
    }

    // Method with parameters
    public void SetMarks(int m1, int m2, int m3)
    {
        marks1 = m1;
        marks2 = m2;
        marks3 = m3;
    }

    // Method with return value
    public int CalculateTotal()
    {
        int total = marks1 + marks2 + marks3;

        return total;
    }

    // Method with return value
    public double CalculateAverage()
    {
        int total = CalculateTotal();

        double average = total / 3.0;

        return average;
    }

    // Method with parameter and return value
    public string GetGrade(double average)
    {
        if (average >= 80)
        {
            return "A";
        }
        else if (average >= 60)
        {
            return "B";
        }
        else if (average >= 50)
        {
            return "C";
        }
        else if (average >= 35)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    // Void method
    public void DisplayDetails()
    {
        Console.WriteLine("=========");

        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
        Console.WriteLine("Marks 1: " + marks1);
        Console.WriteLine("Marks 2: " + marks2);
        Console.WriteLine("Marks 3: " + marks3);

        int total = CalculateTotal();

        double average = CalculateAverage();

        string grade = GetGrade(average);

        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Grade: " + grade);

        Console.WriteLine("=========");
    }
}
   
