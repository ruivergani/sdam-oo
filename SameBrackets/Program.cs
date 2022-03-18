using System;

namespace SameBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            CharStack stack = new CharStack();

            Console.Write("Enter a line of brackets: > ");
            string line = Console.ReadLine();

            try
            {
                foreach (char c in line)
                {
                    if (c == '(')
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

                if (!stack.IsEmpty())
                {
                    Console.WriteLine("Bracket mismatch: there is an opening bracket without a matching closing bracket");
                }
                else
                {
                    Console.WriteLine("Brackets match!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Bracket mismatch: there is a closing bracket without a matching opening bracket");
            }
        }
    }
}
