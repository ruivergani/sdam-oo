using System;

namespace DifferentBrackets
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
                    if (c == '(' || c == '{' || c == '[')
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        char openBracket = stack.Pop();
                        if ((c == ')' && openBracket != '(')
                            || (c == '}' && openBracket != '{')
                            || (c == ']' && openBracket != '['))
                        {
                            throw new ApplicationException("Bracket mismatch: the bracket types do not match");
                        }
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
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Bracket mismatch: there is a closing bracket without a matching opening bracket");
            }
        }
    }
}
