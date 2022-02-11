using System;

namespace w01_task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5 - Restaurant Rating");
            int num = 1;
            int counter = 0;
            while (num != -1) {
                Console.Write("Provide restaurant rating (1-5): ");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num) {
                    case 1:
                        Console.WriteLine("Very poor.");
                        break;
                    case 2:
                        Console.WriteLine("Poor");
                        break;
                    case 3:
                        Console.WriteLine("Middle");
                        break;
                    case 4:
                        Console.WriteLine("Good");
                        break;
                    case 5:
                        Console.WriteLine("Very Good.");
                        break;
                }
                counter = counter + 1;
            }
            Console.WriteLine("Voted by {0} people", counter);
        }
    }
}
