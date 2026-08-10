namespace practiceprom
{
    public class ArrayPractice
    {
        public void PrintArray()
        {
            int[] arr = { 11, 22, 33, 44, 55 };
            Console.WriteLine(arr);
            Console.Write(arr[2]);
            Console.Write(arr[4]);
        }
    }
}
class Array

{
    public void PrintArray()
    {
        int[] arr = { 11,22, 33, 44, 55 };
        Console.Write(arr[2]);
        Console.Write(arr[4]);
    }
    //changing values
}
public class ArrValChanges
{
    public void ChangeArrValues()
    {
        int[] arr = { 11, 22, 33, 44, 55 };
        Console.Write(arr[2]);
        arr[2] = 99;
        arr[3]=233;
        Console.Write(arr[2]);
    }
}
public class ArrLength
{
    public void ArrLengthMet()
    {
        int[] arr = { 11, 22, 33, 44, 55,64,33,66,99 };
        Console.WriteLine(arr.Length);
    }
}
public class ArrLoop
{
    public void ArrLoopMet()
    {
        int[] arr ={22,34,5,6,67,77,};
        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}