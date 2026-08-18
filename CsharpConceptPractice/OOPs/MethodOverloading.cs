using System;

public class MethodOverload
{
    // Add 2 marks
    public int Add(int mark1, int mark2)
    {
        return mark1 + mark2;
    }

    // Add 3 marks
    public int Add(int mark1, int mark2, int mark3)
    {
        return mark1 + mark2 + mark3;
    }

    // Add 5 marks
    public int Add(int mark1, int mark2, int mark3, int mark4, int mark5)
    {
        return mark1 + mark2 + mark3 + mark4 + mark5;
    }

    // Average of 2 marks
    public double Average(int mark1, int mark2)
    {
        return (mark1 + mark2) / 2.0;
    }

    // Average of 3 marks
    public double Average(int mark1, int mark2, int mark3)
    {
        return (mark1 + mark2 + mark3) / 3.0;
    }

    // Average of 5 marks
    public double Average(int mark1, int mark2, int mark3, int mark4, int mark5)
    {
        return (mark1 + mark2 + mark3 + mark4 + mark5) / 5.0;
    }

    // Display student name
    public void Display(string name)
    {
        Console.WriteLine("Student Name: " + name);
    }

    // Display student name and age
    public void Display(string name, int age)
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    public void MethodOver()
    {
        MethodOverload student = new MethodOverload();

        // Display methods
        student.Display("Rahul");

        Console.WriteLine();

        student.Display("Rahul", 21);

        Console.WriteLine();

        // Add 2 marks
        int total2 = student.Add(80, 90);
        Console.WriteLine("Total of 2 marks: " + total2);

        // Add 3 marks
        int total3 = student.Add(80, 90, 70);
        Console.WriteLine("Total of 3 marks: " + total3);

        // Add 5 marks
        int total5 = student.Add(80, 90, 70, 85, 75);
        Console.WriteLine("Total of 5 marks: " + total5);

        Console.WriteLine();

        // Average of 2 marks
        double average2 = student.Average(80, 90);
        Console.WriteLine("Average of 2 marks: " + average2);

        // Average of 3 marks
        double average3 = student.Average(80, 90, 70);
        Console.WriteLine("Average of 3 marks: " + average3);

        // Average of 5 marks
        double average5 = student.Average(80, 90, 70, 85, 75);
        Console.WriteLine("Average of 5 marks: " + average5);
    }


}