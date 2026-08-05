public class ControlStatements
{
    public void IfElseStatement(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }

    public void SwitchStatement(string day)
    {
        switch (day.ToLower())
        {
            case "monday":
                Console.WriteLine("It's Monday!");
                break;
            case "tuesday":
                Console.WriteLine("It's Tuesday!");
                break;
            case "wednesday":
                Console.WriteLine("It's Wednesday!");
                break;
            case "thursday":
                Console.WriteLine("It's Thursday!");
                break;
            case "friday":
                Console.WriteLine("It's Friday!");
                break;
            case "saturday":
                Console.WriteLine("It's Saturday!");
                break;
            case "sunday":
                Console.WriteLine("It's Sunday!");
                break;
            default:
                Console.WriteLine("Invalid day.");
                break;
        }
    }

    public void ForLoopExample(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Iteration {i + 1}");
        }
    }

    public void WhileLoopExample(int n)
    {
        int count = 0;
        while (count < n)
        {
            Console.WriteLine($"Count: {count}");
            count++;
        }
    }

    public void DoWhileLoopExample(int n)
    {
        int count = 0;
        do
        {
            Console.WriteLine($"Count: {count}");
            count++;
        } while (count < n);
    }
}