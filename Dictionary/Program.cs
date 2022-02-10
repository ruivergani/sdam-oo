using System;
using System.Collections.Generic;

namespace Dictionary       /* works as a container for classes and other namespaces */
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ages = new Dictionary<string, int>(){ /* Dictionary: value, key */
                {"Graham", 23},
                {"Phil", 22},
                {"Jan", 25}
            };
            foreach (string person in ages.Keys){    /* print out the dictionary */
                Console.WriteLine(person + " is " + ages[person] + " years old.");
            }
        }
    }
}
