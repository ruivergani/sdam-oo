using System.Collections.Generic;

namespace Average_WithDataInObjects
{

    class Program
    {

        private static MessagePrinter printer = new MessagePrinter();

        static void Main(string[] args)
        {
            ConsoleReader reader = new ConsoleReader();

            AverageCalculator calculator 
                = new AverageCalculator(reader.InputIntegers());

            PrintNumbersWithAverage(calculator);

            bool moreIntegersToEnter 
                = reader.InputYesNo("Do you want to add more integers? (y/n) > ");

            while (moreIntegersToEnter)
            {
                calculator.AddIntegers(reader.InputIntegers());
                PrintNumbersWithAverage(calculator);

                moreIntegersToEnter
                = reader.InputYesNo("Do you want to add more integers? (y/n) > ");
            }
        }

        private static void PrintNumbersWithAverage(AverageCalculator calculator)
        {
            List<int> numbers = calculator.GetCopyOfNumbers();
            if (numbers.Count == 0)
            {
                printer.PrintMessageHeader("\nNo numbers were entered\n");
            }
            else
            {
                double average = calculator.CalculateAverage();

                printer.PrintMessageHeader("Results");
                printer.PrintMessage("\nAverage: " + average + "\n");

                numbers.ForEach(i =>
                {
                    printer.PrintMessage(
                        string.Format(
                            "   {0, 6}: {1}\n", 
                            i, 
                            CompareNumberWithAverage(i, average)));
                });
                printer.PrintMessageHeader("End of Results");
            }
        }

        private static string CompareNumberWithAverage(int num, double avg)
        {
            if (num < avg)
            {
                return "Less than average";
            }
            else if (num > avg)
            {
                return "Greater than average";
            }
            else
            {
                return "Same as average";
            }
        }
    }
}
