using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game!");

            // Start the game
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses) { // !: represents NOT (not out of guesses)
                if (guessCount < guessLimit){
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true; // called flag
                    Console.WriteLine(" ... out of guesses ...");
                }
            }
            if (outOfGuesses) //True
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }

            Console.ReadLine();
        }
    }
}
