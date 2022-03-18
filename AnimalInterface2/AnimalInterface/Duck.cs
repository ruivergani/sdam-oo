using System;

namespace AnimalInterface
{
    class Duck : Animal, IMover, INoiseMaker
    {
        public Duck() : base("Duck")
        {
        }

        public string MakeSound()
        {
            return "quack";
        }

        public string Move()
        {
            return "fly";
        }
    }
}
