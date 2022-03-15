namespace PersonInheritance4
{
    public class Postgraduate : Student
    {
        public string FirstDegree { get; set; }

        public Postgraduate() : this("???", 0, "---")
        {
            // calls the other constructor method for this object
        }

        public Postgraduate(string name, double tuitionFee, string firstDegree) : base(name, tuitionFee)
        {
            // calls the constructor method for the base-class (super-class)
            this.FirstDegree = firstDegree;
        }
    }
}
