using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Rui Vergani Neto"; /* store text */
            int age = 21; /* whole number */
            int characterAge; /* just declaring variable */
            characterAge = 35;
            Console.WriteLine("There once was a men named {0}", characterName); /* concatenate */
            Console.WriteLine("Your name is: " + characterName); /* concatenate */
            Console.WriteLine("He was " + characterAge + " years old.");

            int myInt = 9;
            double myDouble = myInt; // Automatic casting: int to double

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            int number = 10;
            double numberDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(number)); // convert int to string
            Console.WriteLine(Convert.ToDouble(number)); // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble)); // convert double to int
            Console.WriteLine(Convert.ToString(myBool)); // convert bool to string

            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

        }
    }
}
