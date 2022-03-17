using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a List
            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter integer {0}: ", i+1);
                //list.Add(Console.ReadLine());
                list.Add(Convert.ToInt32(Console.ReadLine())); // add to the List
            }

            Console.WriteLine("\nContents of the list:");
            Console.Write("\t");
            foreach (int item in list) // reading item from list 
            {
                Console.Write("{0}  ", item);
            }

            Console.WriteLine("\n\nThe list contains {0} items", list.Count);//List counter
            Console.WriteLine("\nThe list contains 10: {0}", list.Contains(10)); // true or false - comparing the value
            Console.WriteLine("\nThe list contains 12: {0}", list.Contains(12));

            Console.WriteLine("\nRemove 12");
            list.Remove(12); // remove
            Console.WriteLine("The list contains 12: {0}", list.Contains(12));

            list.Reverse(); //reverse
            Console.WriteLine("\nContents of the list after reversal:");
            Console.Write("\t");
            foreach (int item in list)
            {
                Console.Write("{0}  ", item);
            }

            list.Sort(); // sort item
            Console.WriteLine("\n\nContents of the list after sorting:");
            Console.Write("\t");
            foreach (int item in list)
            {
                Console.Write("{0}  ", item);
            }
        }
    }
}
