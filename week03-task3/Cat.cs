using System;
using System.Collections.Generic;
using System.Text;

namespace week03_task3
{
    class Cat : Pet
    {
        public int numberOfTeeth { get; private set; }
        public int lengthOfTail { get; private set; }

        public Cat(string name, string ownerName, int numberOfTeeth, int lengthOfTail) : base(name, ownerName)
        {
            this.numberOfTeeth = numberOfTeeth;
            this.lengthOfTail = lengthOfTail;
        }
    }
}
