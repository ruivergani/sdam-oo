using System;

namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (type variableName in arrayName){    // foreach example
              // code block to be executed
            }

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};    // foreach example
            foreach (string i in cars) {
              Console.WriteLine(i);
            }

            int sum = 0;
            for(int i=0; i < 5; i++){   // for loop 
                Console.Write("Enter an integer > ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Average: " + (sum / 5.0));

            // you can use concept of break/continue in any iteration element

            int day = 4;
            switch (day) {   // switch statement
              case 1:
                Console.WriteLine("Monday");
                break;
              case 2:
                Console.WriteLine("Tuesday");
                break;
              case 3:
                Console.WriteLine("Wednesday");
                break;
              case 4:
                Console.WriteLine("Thursday");
                break;
              case 5:
                Console.WriteLine("Friday");
                break;
              case 6:
                Console.WriteLine("Saturday");
                break;
              case 7:
                Console.WriteLine("Sunday");
                break;
            }
            // Outputs "Thursday" (day 4)

            int i = 0;  // while loop statement
            while (i < 5) 
            {
              Console.WriteLine(i);
              i++;
            }

            int i = 0;  // do while statement
            do 
            {
              Console.WriteLine(i);
              i++;
            }
            while (i < 5);
        }
    }
}
