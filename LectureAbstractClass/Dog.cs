using System;
using System.Collections.Generic;
using System.Text;

namespace LectureAbstractClass
{
    class Dog : Imover, IsoundMaker  //interface
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
        // Part of the interface segregation that is useful
        public void MakeMove()
        {
            Console.WriteLine("Running");
        }
        // the idea would be divide the methods into the interface, to make sure that you do not make a requirement
    }
}
