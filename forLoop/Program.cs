using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop exercise example.");

            for(int i=0; i < 5; i++) // for loop example
            {
                Console.WriteLine("i: " + i);
            }

            //printing array of lucky numbers using for loop
            int[] luckyNumbers = { 1, 2, 3, 4, 5, 6 }; 
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }
    }
}
