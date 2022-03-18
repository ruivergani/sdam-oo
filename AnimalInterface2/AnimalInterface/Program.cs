using System;
using System.Collections.Generic;

namespace AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal application\n");

            List<Animal> zoo = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Duck(),
                new Worm()
            };

            foreach (Animal animal in zoo)
            {
                Console.WriteLine(
                    "\n{0}s can {1} and can {2}",
                    animal.Name,
                    animal.CanMakeSound() ? ((INoiseMaker)animal).MakeSound() : "not make sound",
                    animal.CanMove() ? ((IMover)animal).Move() : "not move");
            }

            zoo.Clear();
        }
    }
}
