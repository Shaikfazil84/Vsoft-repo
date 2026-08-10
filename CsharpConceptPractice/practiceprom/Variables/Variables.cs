using System;
class Variables
{
    public static void Main(string[] args)
    {
        
        int num1=10;
        string num2="five";
        double num3=555.3;
        char num4='A';
        bool num5=true;
        Console.WriteLine($"{num1}, {num2}, {num3}, {num4}, {num5}");
        Variables2 v2=new Variables2();
        v2.Display();
        StoringInObj s=new StoringInObj();
        s.Store();
        UserInput u=new UserInput();
        u.Input();
    }
}
class Variables2
{
    public void Display()
    {
  int nu1=100;
  string nu2="ten";
  Console.WriteLine($"{nu1}+{nu2}");
    }
}    
class StoringInObj
{
    public void Store()
    {
        Store1 s1 = new Store1();
           Store2 s2 = new Store2();


        s1.name1 = "Shaik";
        s1.age1 = 2;
     
        s2.name2 = "Fazil";
        s2.age2 = 2;

        Console.WriteLine($"{s1.name1} {s1.age1}");
        Console.WriteLine($"{s2.name2} {s2.age2}");
    }
}

class Store1
{
    public string?  name1;
    public int age1;
}

class Store2
{
    public string? name2;
    public int age2;
}

class UserInput
{
    public void Input()
    {
        Input1 i1 = new Input1();
        i1.age=21;
        Console.WriteLine($"Enter your Name:");
        i1.name=Console.ReadLine()?? "";
        Console.WriteLine($"Name: {i1.name} Age :- {i1.age}");
    }
}
class Input1
{
    public string? name;
    public int age;
}