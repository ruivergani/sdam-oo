using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ages 
                = new Dictionary<string, int>()
                { 
                    {"Graham", 23}, 
                    {"Phil", 22 }, 
                    {"Jan", 25} 
                };

            foreach (string person in ages.Keys)
            {
                Console.WriteLine(person + " is " + ages[person] + " years old");
            }
        }
    }
}
