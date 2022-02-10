using System;

namespace selection
{
    class Program
    {
        static void Main(string[] args)
        {
            if (condition1){
              // block of code to be executed if condition1 is True
            } 
            else if (condition2) {
              // block of code to be executed if the condition1 is false and condition2 is True
            } 
            else{
              // block of code to be executed if the condition1 is false and condition2 is False
            }

            Console.Write("Type your name: ");
            string name = Console.ReadLine(); /* get user input */

            if (name.Equals("Phil")){
                Console.WriteLine("Brilliant");
            }
            else if (name.Equals("Graham")){
                Console.WriteLine("Fantastic");
            }
            else{
                Console.WriteLine("You decide");
            }
        }
    }                                                   
}
