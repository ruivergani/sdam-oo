namespace PersonInheritance3
{
    public class Person
    {
        public string Name { get; set; }

        public Person() : this("???")
        {
        }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
