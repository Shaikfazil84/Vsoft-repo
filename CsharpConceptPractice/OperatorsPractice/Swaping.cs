using System;
public class Swaping
{
    public void SwapingMet()
    {
        Console.WriteLine("how many will uh enter:");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] numbers=new int[n];
        for(int i=0;i<n;i++){
        Console.WriteLine("enter numbers :\n");
        numbers [i] =Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Numbers entered:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
            int temp=numbers[0];
            numbers[0]=numbers[n-1];
            numbers[n-1]=temp;

    }
}
}