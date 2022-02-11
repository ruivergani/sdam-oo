using System;

namespace w01_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 01 - Sum of Positive and Negative Integers");
            int sumPositive;
            int sumNegative;
            sumPositive = 0;
            sumNegative = 0;
            for (int i = 0; i < 5; i++){
                Console.Write("Type a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0){
                    sumPositive = sumPositive + number;
                }
                else {
                    sumNegative = sumNegative + (-(number));
                }
            }
            Console.WriteLine("\nSum of positive: {0}", sumPositive);
            Console.WriteLine("Sum of negative: {0}", sumNegative);
        }
    }
}
