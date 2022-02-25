using System;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 3.4);

            Console.WriteLine(student1.HasHonors()); // calling the object method
        }
    }
}
