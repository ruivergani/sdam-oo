using System;

namespace IterationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i=0; i < 5; i++)
            {
                Console.Write("Enter an integer > ");
                sum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Average: " + (sum / 5.0));
        }
    }
}
