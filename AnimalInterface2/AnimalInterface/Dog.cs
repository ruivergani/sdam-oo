using System;

namespace AnimalInterface
{
    class Dog : Animal, IMover, INoiseMaker
    {
        public Dog() : base("Dog")
        {
        }

        public string MakeSound()
        {
            return "woof";
        }

        public string Move()
        {
            return "run";
        }
    }
}
