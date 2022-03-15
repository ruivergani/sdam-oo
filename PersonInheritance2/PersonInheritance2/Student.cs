namespace PersonInheritance2
{
    public class Student : Person
    {
        public double Fees { get; set; }

        public Student() : this("???", 0)
        {
            // calls the other constructor method for this object
        }

        public Student(string name, double fees) : base(name)
        {
            this.Fees = fees;
        }
    }
}
