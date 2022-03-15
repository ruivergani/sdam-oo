namespace PersonInheritance4
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

        public override string ToString()
        {
            return string.Format("{0} owes {1:F2} GBP",
                                 Name,
                                 Fees);
        }
    }
}
