using System;

namespace Person_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Address addr1 = new Address(23, "High Street", "Toon Town", "TT4 2RF");
            Address addr2 = new Address(42, "Skirting Board", "LittleTon", "LT2 5GF");

            Person p1 = new Person("Pinocchio", addr1);
            Person p2 = new Person("Jiminy Cricket", addr1);
            Person p3 = new Person("Jerry Mouse", addr2);

            PrintPersonDetails(p1);
            PrintPersonDetails(p2);
            PrintPersonDetails(p3);

            addr1.Street = "Big Avenue";

            PrintPersonDetails(p1);
            PrintPersonDetails(p2);
            PrintPersonDetails(p3);
        }

        private static void PrintPersonDetails(Person p)
        {
            Console.WriteLine(
                "\n{0}\n{1}", 
                p.Name, 
                p.HomeAddress.GetFullAddress());
        }
    }
}
