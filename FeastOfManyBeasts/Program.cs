using System;

namespace FeastOfManyBeasts
{
    class Program
    {
        public static bool Feast(string animalName, string dishName)
        {
            return animalName[0] == dishName[0]
                && animalName[animalName.Length-1] == dishName[dishName.Length-1];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nExpected: True\nActually: " + Feast("great blue heron", "garlic naan"));
            Console.WriteLine("\nExpected: True\nActually: " + Feast("chickadee", "chocolate cake"));
            Console.WriteLine("\nExpected: False\nActually: " + Feast("chicken", "curry and chips"));
            Console.WriteLine("\nExpected: True\nActually: " + Feast("chamois", "curry and chips"));
        }
    }
}
