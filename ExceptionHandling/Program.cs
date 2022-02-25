using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trueval = false;
            do
            {
                try
                {
                    Console.Write("\nEnter a number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int result = (num1 / num2);
                    Console.WriteLine("Resultado: " + result);
                    trueval = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); //catch the error and display a message
                    trueval = true;
                }
            }
            while (trueval == true);
            // exception block
            trueval = false;
            
        }
    }
}
