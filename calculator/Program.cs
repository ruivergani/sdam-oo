using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());      // convert to double (float numbers)

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Result: ", num1 + num2); // add because we converted to integer

            Console.ReadLine();
        }
    }
}
