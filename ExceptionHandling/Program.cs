using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception block
            try {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (Exception e){
                Console.WriteLine(e.Message); //catch the error and display a message

            }
        }
    }
}
