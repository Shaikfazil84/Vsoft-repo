using System;
using System.Collections.Generic;
namespace practiceprom
{
    public class Dictionary
    {
        public void DictionaryPrac()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1,"fazil");
            dict.Add(2,"sharif");
            dict.Add(3,"shaifa");
            Console.WriteLine(dict[1]);
            Console.WriteLine(dict[2]);
            Console.WriteLine(dict[3]);
        }
    }
    public class DitctionaryLoop
    {
        public void DictionaryLoop()
        {
            Dictionary<int,string> dict=new Dictionary<int,string>();
            dict.Add(1,"shaik");
            dict.Add(2,"fazil");
            dict.Add(3,"shaifa");
            foreach(KeyValuePair<int,string>item in dict)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
    public class DictionaryAccess
    {
        public void DictionaryAccessMet()
        {
            Dictionary<int,string> dict=new Dictionary<int,string>();
            dict.Add(1,"shaik");
            dict.Add(2,"fazil");
            dict.Add(3,"shaifa");
            Console.WriteLine(dict[1]);
            Console.WriteLine(dict[2]);
            dict[2]="basha";
            Console.WriteLine(dict[2]);
            dict.Add(4,"Adil");
            Console.WriteLine(dict[4]);
            dict.Remove(1);
            foreach(KeyValuePair<int,string>item in dict)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}