using System;
using System.Collections.Generic;

namespace Average_NoObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = InputIntegers();

            double average = CalculateAverage(nums);

            PrintNumbersWithAverage(nums, average);
        }

        private static List<int> InputIntegers()
        {
            List<int> integers = new List<int>();

            int num = ReadInteger("Enter an integer (-1 to end) > ");

            while (num != -1)
            {
                integers.Add(num);
                num = ReadInteger("Enter an integer (-1 to end) > ");
            }

            return integers;
        }

        private static int ReadInteger(string prompt)
        {
            int num = -1;
            bool dataOK = false;
            while (!dataOK)
            {
                Console.Write(prompt);
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    dataOK = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not an integer. Please try again.");
                }
            }

            return num;
        }

        private static double CalculateAverage(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return 0;
            }

            int sum = 0;
            numbers.ForEach(i => sum += i);

            return (double)sum / numbers.Count;
        }

        private static void PrintNumbersWithAverage(List<int> numbers, double average)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("\nNo numbers were entered");
            }
            else
            {
                Console.WriteLine("\nAverage: " + average);

                numbers.ForEach(i =>
                {
                    Console.WriteLine("   {0, 6}: {1}", i, CompareNumberWithAverage(i, average));
                });
            }
        }

        private static string CompareNumberWithAverage(int num, double avg)
        {
            if (num < avg)
            {
                return "Less than average";
            }
            else if (num > avg)
            {
                return "Greater than average";
            }
            else
            {
                return "Same as average";
            }
        }
    }
}
