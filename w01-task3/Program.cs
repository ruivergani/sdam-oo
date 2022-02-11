using System;

namespace w01_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 03 - Dice Match");
            int counter = 0;
            int dice1 = 1;
            int dice2 = 2;
            while (dice1 != dice2){
                Random rnd = new Random();
                dice1 = rnd.Next(1, 6); // generate random number 1 - 6
                dice2 = rnd.Next(1, 6); // generate random number 1 - 6
                Console.WriteLine("Dice 1: " + dice1);
                Console.WriteLine("Dice 2: " + dice2);
                Console.WriteLine("");
                counter += 1;
            }
            Console.WriteLine("It took {0}", counter);
        }
    }
}
