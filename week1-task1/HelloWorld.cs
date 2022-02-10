using System;

namespace week1_task1
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name?");
            string name = Console.ReadLine(); /* declare variable and get data from user */
            Console.WriteLine("\n \tHello {0}", name);

            Console.Write("\nWhat is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n \t Hello {0}, you are {1} years old", name, age);
        }
    }
}
