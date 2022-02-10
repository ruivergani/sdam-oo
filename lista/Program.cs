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

            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            int[] luckyNumbers = { 4, 3, 5, 6, 77 }; // creating an array
        }
    }
}
