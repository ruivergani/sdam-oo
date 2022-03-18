using System;

namespace AnimalInterface
{
    class Dog : Animal
    {
        private void Bark()
        {
            Console.WriteLine("Woof");
        }
        private void Run()
        {
            Console.WriteLine("Running");
        }

        public void MakeSound()
        {
            Bark();
        }

        public void Move()
        {
            Run();
        }
    }
}
