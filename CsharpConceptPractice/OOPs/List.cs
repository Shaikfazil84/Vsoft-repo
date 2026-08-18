using System;
using System.Collections.Generic;

public class StudentMarks
{
    public void Run()
    {
        List<int> marks = new List<int>();

        marks.Add(80);
        marks.Add(60);
        marks.Add(90);

        Console.WriteLine("After Add:");
        Display(marks);

        marks.AddRange(new int[] { 70, 50 });

        Console.WriteLine("\nAfter AddRange:");
        Display(marks);

        marks.Insert(1, 85);

        Console.WriteLine("\nAfter Insert:");
        Display(marks);

        marks.Remove(50);

        Console.WriteLine("\nAfter Remove(50):");
        Display(marks);
        marks.RemoveAt(0);

        Console.WriteLine("\nAfter RemoveAt(0):");
        Display(marks);

        Console.WriteLine("\nContains 90: " + marks.Contains(90));
        Console.WriteLine("Index of 90: " + marks.IndexOf(90));

        Console.WriteLine("Number of marks: " + marks.Count);

        marks.Sort();

        Console.WriteLine("\nAfter Sort:");
        Display(marks);

        marks.Reverse();

        Console.WriteLine("\nAfter Reverse:");
        Display(marks);

        marks.RemoveAll(x => x < 70);

        Console.WriteLine("\nAfter RemoveAll(marks < 70):");
        Display(marks);

        marks.Clear();

        Console.WriteLine("\nAfter Clear:");
        Console.WriteLine("Number of marks: " + marks.Count);
    }

    public void Display(List<int> marks)
    {
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }

        Console.WriteLine();
    }

}