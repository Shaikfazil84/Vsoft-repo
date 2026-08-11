using System;
using System.Collections.Generic;

namespace practiceprom
{
    public class ListPractice
    {
        public void ListPrint()
        {
            // 1. Creating an empty List
            List<int> list = new List<int>();

            // Adding values
            list.Add(24);
            list.Add(23);
            list.Add(32);

            Console.WriteLine("\nList:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            // 2. Creating a List with values
            List<int> list1 = new List<int>
            {
                11, 23, 40, 42, 56, 66
            };

            Console.WriteLine("\nList1:");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }


            // 3. Empty List and adding values
            List<int> number = new List<int>();

            number.Add(22);
            number.Add(33);

            // 4. Changing values
            number[0] = 99;
            // Remove() values
            number.Remove(22);

            Console.WriteLine("\nNumber List:");
            for (int i = 0; i < number.Count; i++)
            {
                Console.WriteLine(number[i]);
            }


            // 6. Another List
            List<int> list3 = new List<int>
            {
                12, 22, 3, 45, 67, 88, 44
            };

            // RemoveAt()
            list3.RemoveAt(3);

            // Insert() adds a value
            list3.Insert(4, 66);

            Console.WriteLine("\nList3:");
            for (int i = 0; i < list3.Count; i++)
            {
                Console.WriteLine(list3[i]);
            }
        }
    }
}