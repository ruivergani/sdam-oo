using System;

namespace PrintLine_WithObject
{
    class MessagePrinter
    {

        public void PrintMessageHeader(string headerText)
        {
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
            Console.WriteLine(line);
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
