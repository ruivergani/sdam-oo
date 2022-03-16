using System;
using System.Collections.Generic;
using System.Text;

namespace week03_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting the Diagram into Program.");
            // There is no need to declare previous superclass
            Pet pet1 = new Pet("Toby", "Owner 1");
            Pet pet2 = new Pet("Tobias", "Owner 2");

            //SubClass cat - can declare without superclass
            Cat cat1 = new Cat(pet1.name, pet1.ownerName, 28, 10);
            Cat cat2 = new Cat(pet2.name, pet1.ownerName, 24, 12);
            Cat cat3 = new Cat("Mingau", pet2.ownerName, 26, 15);

            Budgie budgie1 = new Budgie("---", "---", "Blue");
            Budgie budgie2 = new Budgie("---", "---", "Yellow");

            Console.WriteLine("All pets\n========");
            Console.WriteLine(
                "\t{0:8}   {1:10}   {2:5}   {3:11}   {4:14}",
                "Pet name", "Owner name", "Teeth", "Tail length", "Feather colour");
            Console.WriteLine(
                "\t{0:8}   {1:10}   {2:5}   {3:11}   {4:14}",
                "========", "==========", "=====", "===========", "==============");

            printCat(cat1);
            printCat(cat2);
            printCat(cat3);

            printBudgie(budgie1);
            printBudgie(budgie2);

        }
        // create methods for printing
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
