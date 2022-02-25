using System;

namespace ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exponent Function");
            Console.WriteLine(GetPow(3, 2)); // function get power 3 ^ 2

            // creating 2D array
            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            Console.WriteLine(numberGrid[0, 0]); // accessing values
            Console.WriteLine(numberGrid[1, 1]);

            int[,] myArray = new int[2, 3]; // rows and collumns (because you do not know the elements) 

        }
        // creating function
        // basically the function does not need to be before the main method
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++) // to limit the power num
            {
                result = result * baseNum;
            }

            return result;
        }

    }
}
