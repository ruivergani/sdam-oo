namespace PersonInheritance2
{
    public class Teacher : Person
    {
        public double Wage { get; set; }

        public Teacher() : this("???", 0)
        {
        }

        public Teacher(string name, double wage) : base(name)
        {
            this.Wage = wage;
        }
    }
}
