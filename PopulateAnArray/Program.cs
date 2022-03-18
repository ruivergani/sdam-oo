using System;

namespace PopulateAnArray
{
    class Program
    {
        public static int[] PopulateArray(int num)
        {
            int[] array = new int[num];

            for (int i = 0; i < num; i++)
            {
                array[i] = i + 1;
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.Write("\nExpected: [1, 2, ]\nActually: [");
            foreach (int i in PopulateArray(2))
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("]");

            Console.Write("\nExpected: [1, 2, 3, 4, 5, 6, ]\nActually: [");
            foreach (int i in PopulateArray(6))
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
