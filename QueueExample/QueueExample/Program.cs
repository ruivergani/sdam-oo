using System;

namespace QueueExample
{
    class Program
    {
        private static char[] operators = { '+', '-', '*', '/' }; // array

        static void Main(string[] args)
        {
            Random rand = new Random(); // random number
            ResultQueue q = new ResultQueue();

            for (int i = 0; i < 10; i++)
            {
                int num1 = rand.Next(1, 101); // generate random value min-max
                int num2 = rand.Next(1, 101);
                char op = operators[rand.Next(0, operators.Length)]; // random value from the array
                Result r = new Result(num1, num2, op);
                //Console.WriteLine(r);
                q.Enqueue(r); // add to the list
            }

            Console.WriteLine();
            while (!q.IsEmpty()) // while the queue is not empty (true)
            {
                Console.WriteLine(q.Dequeue().ToString());
            }
        }
    }
}
