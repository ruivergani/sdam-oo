using System;

namespace Youre_A_Square
{
    class Program
    {
        public static bool IsSquare(int num)
        {
            int n = (int)Math.Sqrt(num);

            return n * n == num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nExpected: False\nActually: " + IsSquare(-1));
            Console.WriteLine("\nExpected: True\nActually: " + IsSquare(0));
            Console.WriteLine("\nExpected: False\nActually: " + IsSquare(3));
            Console.WriteLine("\nExpected: True\nActually: " + IsSquare(4));
            Console.WriteLine("\nExpected: True\nActually: " + IsSquare(25));
            Console.WriteLine("\nExpected: False\nActually: " + IsSquare(26));
        }
    }
}
