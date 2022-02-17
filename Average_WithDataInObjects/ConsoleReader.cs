using System;
using System.Collections.Generic;

namespace Average_WithDataInObjects
{
    class ConsoleReader
    {

        private MessagePrinter printer = new MessagePrinter();

        public List<int> InputIntegers()
        {
            List<int> integers = new List<int>();

            int num = ReadInteger("Enter an integer (-1 to end) > ");

            while (num != -1)
            {
                integers.Add(num);
                num = ReadInteger("Enter an integer (-1 to end) > ");
            }

            return integers;
        }

        private int ReadInteger(string prompt)
        {
            int num = -1;
            bool dataOK = false;
            while (!dataOK)
            {
                printer.PrintMessage(prompt);
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    dataOK = true;
                }
                catch (FormatException)
                {
                    printer.PrintMessage("That was not an integer. Please try again.\n");
                }
            }

            return num;
        }

        public bool InputYesNo(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower().StartsWith('y');
        }

    }
}
