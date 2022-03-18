using System;
using System.Collections.Generic;

namespace AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal application\n");

            Animal a = new Cat();
            a.MakeSound();

            a = new Dog();
            a.MakeSound();

            a = new Duck();
            a.MakeSound();

            Console.WriteLine("\nFill list");
            List<Animal> zoo = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Duck(),
                new Cat()
            };

            foreach (Animal animal in zoo)
            {
                Console.WriteLine();
                animal.MakeSound();
                animal.Move();
            }

            zoo.Clear();
        }
    }
}
