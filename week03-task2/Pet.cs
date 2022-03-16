using System;
using System.Collections.Generic;
using System.Text;

namespace week03_task2
{
    public class Pet
    {
        public string name { get; private set; }
        public string ownerName { get; private set; }

        public Pet(string name, string ownerName) // constructor
        {
            this.name = name;
            this.ownerName = ownerName;
        }
        public string getName()
        {
            return name;
        }
        public string getOwnerName()
        {
            return ownerName;
        }
    }
}
