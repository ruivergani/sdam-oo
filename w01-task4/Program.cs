using System;

namespace w01_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 4 - Rainbow");
            string[] rainbow = {"red", "orange", "yellow", "green", "blue", "indigo", "violet" }; // array with colors of rainbow
            int num = 2;
            while (num != -1){
                Console.Write("Enter a number 1-7 (-1 to stop): ");
                num = Convert.ToInt32(Console.ReadLine());
                int result = num - 1;
                if (num != -1){
                    Console.WriteLine("Color: {0}", rainbow[result]);
                }
                else {
                    Console.WriteLine("Program exited...");
                }
                
            }
        }
    }
}
