using System;

namespace AnimalInterface
{
    class Cat : Animal
    {
        private void Meow()
        {
            Console.WriteLine("Meow");
        }
        private void Stalk()
        {
            Console.WriteLine("Stalking");
        }

        public void MakeSound()
        {
            Meow();
        }

        public void Move()
        {
            Stalk();
        }
    }
}
