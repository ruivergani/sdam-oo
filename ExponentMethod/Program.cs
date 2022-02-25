using System;

namespace ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exponent Function");
            Console.WriteLine(GetPow(3, 2)); // function get power 3 ^ 2
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
