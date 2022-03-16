using System;
using System.Collections.Generic;
using System.Text;

namespace week03_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using an Array to store Pets.");
            // Array
            Pet[] pets =
                {
                    new Cat("Cat 1", "Owner 10", 28, 2),
                    new Cat("Cat 2", "Owner 11", 24, 4),
                    new Cat("Cat 3", "Owner 12", 26, 6),
                    new Cat("Cat 4", "Owner 13", 25, 8),
                    new Cat("Cat 5", "Owner 14", 24, 10),
                    new Cat("Cat 6", "Owner 15", 23, 12),

                    new Budgie("Budgie 1", "Owner 21", "Blue"),
                    new Budgie("Budgie 2", "Owner 22", "Yellow"),
                    new Budgie("Budgie 3", "Owner 23", "Green"),
                    new Budgie("Budgie 4", "Owner 24", "White")
                };
            PrintPetDetails(pets); //printing an array

        }

        private static void PrintPetDetails(Pet[] pets) // passing a as Array (Pet)
        {
            Console.WriteLine("All pets\n========");
            Console.WriteLine(
                "\t{0:8}   {1:10}   {2:5}   {3:11}   {4:14}",
                "Pet name", "Owner name", "Teeth", "Tail length", "Feather colour");
            Console.WriteLine(
                "\t{0:8}   {1:10}   {2:5}   {3:11}   {4:14}",
                "========", "==========", "=====", "===========", "==============");

            foreach (Pet item in pets) // foreach structure
            {
                // validate either is cat or budgie
                if(item is Cat)
                {
                    printCat((Cat) item);
                }
                else if(item is Budgie)
                {
                    printBudgie((Budgie) item);
                }
            }
        
        }
        // create methods for printing Cat and Budgie
        private static void printCat(Cat c)
        {
            Console.WriteLine(
                "\t{0, -8}   {1, -10}   {2, 5:D2}   {3, 11:D2}   {4, 14}",
                c.name, c.ownerName, c.numberOfTeeth, c.lengthOfTail, "---");
        }
        private static void printBudgie(Budgie b)
        {
            Console.WriteLine(
                "\t{0, -8}   {1, -10}   {2, 5}   {3, 11}   {4, 14}",
                b.name, b.ownerName, "---", "---", b.colourOfFeathers);
        }
    }
}
