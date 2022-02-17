using System;

namespace PrintLine_NoObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLineOfCharacter('=', 17);
            PrintMessage("Here is a message");
            PrintLineOfCharacter('=', 17);
            PrintMessage("\nHello World!\n");
            PrintLineOfCharacter('-', 14);
            PrintMessage("End of message");
            PrintLineOfCharacter('-', 14);
        }

        private static void PrintMessage(string line)
        {
            Console.WriteLine(line);
        }

        private static void PrintLineOfCharacter(char ch, int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
}
