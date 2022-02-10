using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());      // convert to double (float numbers)

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if(op == "-"){
                Console.WriteLine(num1 - num2);
            }
            else if(op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if(op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Operator not found.");
            }

            Console.ReadLine();
        }
    }
}
