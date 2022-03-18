using System;

namespace AnimalInterface
{
    class Cat : Animal, IMover, INoiseMaker
    {
        public Cat() : base("Cat")
        {
        }

        public string MakeSound()
        {
            return "meow";
        }

        public string Move()
        {
            return "stalk";
        }
    }
}
