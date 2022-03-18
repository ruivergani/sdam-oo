using System;

namespace AnimalInterface
{
    class Worm : Animal, IMover
    {
        public Worm() : base("Worm")
        {
        }

        public string Move()
        {
            return "slither";
        }
    }
}
