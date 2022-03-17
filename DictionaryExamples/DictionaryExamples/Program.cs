using System;
using System.Collections.Generic;

namespace DictionaryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Person> dict = new Dictionary<int, Person>();
            SortedDictionary<int, Person> sDict = new SortedDictionary<int, Person>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} Enter Person Id: ", i + 1);
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("\tEnter Person Name: ", i + 1);
                string name = Console.ReadLine();

                Person p = new Person
                {
                    PersonId = id,
                    Name = name
                };

                dict.Add(id, p);
                sDict.Add(id, p);
            }

            Console.WriteLine("\nContents of the dictionary:");
            foreach (Person p in dict.Values)
            {
                Console.WriteLine("\t" + p);
            }

            Console.WriteLine("\nContents of the sorted dictionary:");
            foreach (Person p in sDict.Values)
            {
                Console.WriteLine("\t" + p);
            }
        }
    }
}
