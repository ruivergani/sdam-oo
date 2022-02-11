using System;

namespace w01_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 02 - Grid (Beginner)");
            Console.Write("Enter row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column: ");
            int column = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < row;i++){
                for (int j = 0; j < column; j++){
                    Console.Write(" * ");
                }
                Console.WriteLine("");
            }
        }
    }
}
