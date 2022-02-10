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

            // Create an Array
            string[] cars;
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]); // outputs volvo
            for (int i = 0; i < cars.Length; i++){        // print out the array (length is a function/method of the class/object cars)
                Console.WriteLine(cars[i]);
            }
            foreach (string i in cars){         //using foreach to printout
                Console.WriteLine(i);
            }
        }
    }
}
