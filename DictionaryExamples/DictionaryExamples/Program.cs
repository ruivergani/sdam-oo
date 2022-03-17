using System;
using System.Collections.Generic;

namespace DictionaryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // DICTIONARY IN C#
            Dictionary<int, Person> dict = new Dictionary<int, Person>();
            SortedDictionary<int, Person> sDict = new SortedDictionary<int, Person>(); // sort by values

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
                Console.WriteLine(p.Name + p.PersonId);
                dict.Add(id, p); //adding person p with this key (id) to the values p(id and name)
                sDict.Add(id, p);
            }

            Console.WriteLine("\nContents of the dictionary:");
            foreach (Person p in dict.Values) // GET VALUES
            {
                Console.WriteLine("\t" + p);
            }

            Console.WriteLine("\nContents of the sorted dictionary:");
            foreach (Person p in sDict.Values) // GET SORTED VALUES
            {
                Console.WriteLine("\t" + p);
            }
        }
    }
}
