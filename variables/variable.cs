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
        }
    }
}
