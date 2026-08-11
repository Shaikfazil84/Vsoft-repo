using System;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main(string[] args)
    {
        Student student =new Student();
        student.ShowStudent();
        Employee employee =new Employee();
        employee.ShowEmployee();
        Car car =new Car();
        car.ShowCar();
    }
}
class Student
{
    public void ShowStudent()
    {
        Console.WriteLine("student Details");
        DisplayName();
    }
    private void DisplayName()
    {
        Console.WriteLine("Name:Fazil");
    }
}
class Employee
{
    public void ShowEmployee()
    {
        Console.WriteLine("Emplayee details");
        DispalyName();
    }
    private void DispalyName()
    {
        Console.WriteLine("Salary:30000");
    }
}
class Car
{
    public void ShowCar()
    {
        Console.WriteLine("car deatils");
        DisplayName();
    }
    private void DisplayName()
    {
        Console.WriteLine("Model:BMW");
    }
}