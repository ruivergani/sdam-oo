using System;

namespace AnimalInterface
{
    class Duck : Animal
    {
        private void Quack()
        {
            Console.WriteLine("Quack");
        }
        private void Fly()
        {
            Console.WriteLine("Flying");
        }

        public void MakeSound()
        {
            Quack();
        }

        public void Move()
        {
            Fly();
        }
    }
}
