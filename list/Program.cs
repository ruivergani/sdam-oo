using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();     /* creating a list */
            
            for (int i=0; i < 5; i++){  /* For to type data into list */
                Console.Write("Enter an integer > ");
                nums.Add(Convert.ToInt32(Console.ReadLine()));  /* Add to the list - convert data to integer */
            }
            
            for (int i=0; i < nums.Count; i++){    /* For to print out the data */
                Console.Write(nums[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
