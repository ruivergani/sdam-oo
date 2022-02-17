using System;

namespace SelectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? > ");
            string name = Console.ReadLine();

            if (name.Equals("Phil"))
                Console.WriteLine("Brilliant!");
            else if (name.Equals("Graham"))
                Console.WriteLine("Fantastic!");
            else
                Console.WriteLine("You decide");
        }
    }
}
