namespace AnimalInterface
{
    abstract class Animal
    {
        public string Name { get; private set; }

        protected Animal(string name)
        {
            this.Name = name;
        }

        public bool CanMove()
        {
            return this is IMover;
        }

        public bool CanMakeSound()
        {
            return this is INoiseMaker;
        }
    }
}
