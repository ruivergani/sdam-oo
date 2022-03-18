using System;
using System.Collections.Generic;
using System.Text;

namespace LectureAbstractClass
{
    class Cat : Pet
    {
        public int NumberOfTeeth { get; }
        public int LengthOfTail { get;  }

        public Cat(string name, string ownerName, int numberOfTeeth, int lengthOfTail) : base(name, ownerName) // this make reference to the superclass attributes - initialise these parameters
        {
            NumberOfTeeth = numberOfTeeth;
            LengthOfTail = lengthOfTail;
        }
        // must implement the abstract ToString
        public override string ToString()
        {
            return $"Cat '{name}' has {NumberOfTeeth} teeth and a {LengthOfTail} cm of tail.";
        }
        // Hammerhead : Shark : Animal
    }
}
