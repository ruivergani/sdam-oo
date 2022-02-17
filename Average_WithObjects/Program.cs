using System.Collections.Generic;

namespace Average_WithObjects
{

    class Program
    {

        private static MessagePrinter printer = new MessagePrinter();

        static void Main(string[] args)
        {
            ConsoleReader reader = new ConsoleReader();
            AverageCalculator calculator = new AverageCalculator();

            List<int> nums = reader.InputIntegers();

            double average = calculator.CalculateAverage(nums);

            PrintNumbersWithAverage(nums, average);
        }

        private static void PrintNumbersWithAverage(List<int> numbers, double average)
        {
            if (numbers.Count == 0)
            {
                printer.PrintMessageHeader("\nNo numbers were entered\n");
            }
            else
            {
                printer.PrintMessageHeader("Results");
                printer.PrintMessage("\nAverage: " + average + "\n");

                numbers.ForEach(i =>
                {
                    printer.PrintMessage(string.Format("   {0, 6}: {1}\n", i, CompareNumberWithAverage(i, average)));
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
