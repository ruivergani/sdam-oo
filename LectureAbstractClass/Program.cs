using System;
using System.Collections.Generic;

namespace LectureAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of using Abstract");
            //Pet p = new Pet("My pet", "Rui Neto"); this is an abstraction concept not real animal

            Pet pet1 = new Cat("My pet", "Rui Neto", 28, 12); // superclass Pet using Cat as an instance

            // creating a list of Pets
            List<Pet> petsList = new List<Pet>()
            {
                new Cat("My pet", "Rui Neto", 28, 12)
            };

            foreach  (Pet item in petsList) // pet type - press tab 2xtimes
            {
                Console.WriteLine(item.ToString()); // call the To String method
            }
        }
    }
}
