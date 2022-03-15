using System;

namespace PersonInheritance4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
            new Person("Graham"),
            new Teacher("Janet", 123456.78),
            new Student("Jimmy", 7612.99),
            new Postgraduate("Jody", 8595.99, "Bee keeping")
        };

            int count = 0;
            foreach (Person p in people)
            {
                count++;
                Console.WriteLine("\nPerson " + count);
                Console.WriteLine("\tName: " + p.Name);

                if (p is Teacher)
                {
                    Console.WriteLine("\tRole: Teacher");
                    Teacher t = (Teacher)p;
                    Console.WriteLine("\tWage: {0:F2}", t.Wage);
                }
                else if (p is Postgraduate)
                {
                    Console.WriteLine("\tRole: Postgraduate student");
                    Postgraduate pg = (Postgraduate)p;
                    Console.WriteLine("\tFees: {0:F2}", pg.Fees);
                    Console.WriteLine("\t1st degree: " + pg.FirstDegree);
                }
                else if (p is Student)
                {
                    Console.WriteLine("\tRole: Student");
                    Student s = (Student)p;
                    Console.WriteLine("\tFees: {0:F2}", s.Fees);
                }

                Console.WriteLine("\tToString(): " + p.ToString());
            }
        }
    }
}
