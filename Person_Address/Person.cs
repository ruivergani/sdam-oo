namespace Person_Address
{
    class Person
    {
        public string Name { get; }
        public Address HomeAddress { get; }

        public Person(string name, Address homeAddress)
        {
            Name = name;
            HomeAddress = homeAddress;
        }
    }
}
