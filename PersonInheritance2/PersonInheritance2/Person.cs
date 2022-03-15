namespace PersonInheritance2
{
    public class Person
    {
        public string Name { get; set; }

        public Person() : this("???") // can have two constructors
        {
        }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
