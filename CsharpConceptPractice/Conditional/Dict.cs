using System;
public static class Dict
{
  public static void Display()
    {
        Dictionary <string,int> dict= new Dictionary<string,int>();
    dict.Add("faz",22);
    dict.Add("basha",55);
    dict.Add("shaik",23);
    foreach(KeyValuePair<string,int> item in dict)
        {
            Console.WriteLine(item.Key +" " + item.Value);
        }
    }
}