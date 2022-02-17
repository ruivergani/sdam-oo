using System;

namespace PrintLine_WithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            MessagePrinter printer = new MessagePrinter();

            printer.PrintMessageHeader("Here is a message");
            printer.PrintMessage("\nHello World!\n");
            printer.PrintMessageFooter("End of message");
        }
    }
}
