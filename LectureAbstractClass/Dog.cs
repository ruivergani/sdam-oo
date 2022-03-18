using System;
using System.Collections.Generic;
using System.Text;

namespace LectureAbstractClass
{
    class Dog : IAnimal  //interface
    {
        // must implement the methods from the interface
        public void Move()
        {
            Console.WriteLine("Running");
        }
        public void MakeSound()
        {
            Console.WriteLine("Barking");
        }
    }
}
