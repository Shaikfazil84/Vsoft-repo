using System;

public class StringAnalyzer
{
    public void Run()
    {
        string[] students = new string[2];
        for (int i = 0; i < students.Length; i++)
        {
            Console.Write("Enter student " + (i + 1) + " name: ");
            students[i] = (Console.ReadLine()??"").Trim();

            Console.WriteLine("Name: " + students[i]);
            Console.WriteLine("Uppercase: " + students[i].ToUpper());
            Console.WriteLine("Lowercase: " + students[i].ToLower());
            Console.WriteLine("Length: " + students[i].Length);

            if (students[i].ToLower().Contains("a"))
            {
                Console.WriteLine("Contains A: True");
            }
            else
            {
                Console.WriteLine("Contains A: False");
            }

            if (students[i].ToUpper().StartsWith("S"))
            {
                Console.WriteLine("Starts with S: True");
            }
            else
            {
                Console.WriteLine("Starts with S: False");
            }

            Console.WriteLine();
        }

        Console.WriteLine("----- ALL STUDENTS -----");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        string longest = students[0];
        string shortest = students[0];

        foreach (string student in students)
        {
            if (student.Length > longest.Length)
            {
                longest = student;
            }

            if (student.Length < shortest.Length)
            {
                shortest = student;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Longest name: " + longest);
        Console.WriteLine("Shortest name: " + shortest);
        int count = 0;

        foreach (string student in students)
        {
            if (student.ToLower().Contains("a"))
            {
                count++;
            }
        }

        Console.WriteLine("Names containing A: " + count);

        Console.WriteLine();
        Console.Write("Enter a name to search: ");
        string searchName =( Console.ReadLine()??"").Trim();

        bool found = false;

        foreach (string student in students)
        {
            if (student.ToLower() == searchName.ToLower())
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Student found!");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
        Console.WriteLine();
        Console.WriteLine("----- REVERSE ORDER -----");

        for (int i = students.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(students[i]);
        }
    }
}