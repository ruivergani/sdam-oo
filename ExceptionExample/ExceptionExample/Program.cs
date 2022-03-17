using System;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //WithoutExceptions();
            WithExceptionHandling();
        }

        private static void WithoutExceptions()
        {
            Console.Write("Num1: > ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Num2: > ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine("{0:d} / {1:d} = {2:d}", num1, num2, result);
        }

        private static void WithExceptionHandling()   // using multiple catch 
        {
            try
            {
                int num1 = ReadInteger("Num1: > ");
                int num2 = ReadInteger("Num2: > ");
                int result = num1 / num2;
                Console.WriteLine("{0:d} / {1:d} = {2:d}", num1, num2, result);
            }
            catch (System.DivideByZeroException dbze)
            {
                Console.WriteLine("ERROR: {0:s}\n\tPlease run the program again", dbze.Message);
            }
            catch (System.FormatException fe)
            {
                Console.WriteLine("ERROR: {0:s}\n\tPlease run the program again", fe.Message);
            }
        }

        private static int ReadInteger(string prompt) //using a loop exception which is the ideal
        {
            int num = -1;
            bool dataOK = false;

            do {
                try {
                    Console.Write(prompt);
                    num = Convert.ToInt32(Console.ReadLine()); ;
                    dataOK = true;
                }
                catch (System.FormatException fe) {
                    Console.WriteLine("\nThis is not an integer. Please try again.");
                }
            }
            while (!dataOK);

            return num;
        }
    }
}
