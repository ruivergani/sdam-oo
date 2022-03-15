using System;

namespace PersonInheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Graham");
            Teacher t1 = new Teacher("Janet", 123456.78);
            Student s1 = new Student("Jimmy", 7612.99);
            Postgraduate pg1 = new Postgraduate("Jody", 8595.99, "Bee keeping");

            p1.Name = "Graham";

            t1.Name = "Janet";
            t1.Wage = 123456.78;

            s1.Name = "Jimmy";
            s1.Fees = 7612.99;

            pg1.Name = "Jody";
            pg1.Fees = 8595.99;
            pg1.FirstDegree = "Bee keeping";

            Console.WriteLine("Person");
            Console.WriteLine("\tName: " + p1.Name);

            Console.WriteLine("\nTeacher");
            Console.WriteLine("\tName: " + t1.Name);
            Console.WriteLine("\tWage: {0:F2}", t1.Wage);

            Console.WriteLine("\nStudent");
            Console.WriteLine("\tname: " + s1.Name);
            Console.WriteLine("\tFees: {0:F2}", s1.Fees);

            Console.WriteLine("\nPostgraduate student");
            Console.WriteLine("\tname: " + pg1.Name);
            Console.WriteLine("\tFees: {0:F2}", pg1.Fees);
            Console.WriteLine("\t1st degree: " + pg1.FirstDegree);
        }
    }
}
