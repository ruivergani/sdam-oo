using System;

namespace EnterAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer > ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + num);
        }
    }
}
