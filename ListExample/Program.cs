using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            for (int i=0; i<5; i++)
            {
                Console.Write("Enter an integer > ");
                nums.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
