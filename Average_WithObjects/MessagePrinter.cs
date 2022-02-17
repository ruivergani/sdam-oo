using System;

namespace Average_WithObjects
{
    class MessagePrinter
    {

        public void PrintMessageHeader(string headerText)
        {
            Console.WriteLine();
            PrintLineOfCharacter('=', headerText.Length);
            Console.WriteLine(headerText);
            PrintLineOfCharacter('=', headerText.Length);
        }

        public void PrintMessageFooter(string footerText)
        {
            PrintLineOfCharacter('-', footerText.Length);
            Console.WriteLine(footerText);
            PrintLineOfCharacter('-', footerText.Length);
        }

        public void PrintMessage(string line)
        {
            Console.Write(line);
        }

        private void PrintLineOfCharacter(char ch, int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
}
