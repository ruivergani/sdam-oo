using System;
using System.Collections.Generic;

namespace Company_Person_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet dog = new Pet("Nina");
            Pet cat = new Pet("Mingau");

            Person person01 = new Person("Jake Alves", cat);
            Person person02 = new Person("Rui Neto", dog);
            Person person03 = new Person("Jordan", dog);

            List<Person> peopleList = new List<Person>();
            peopleList.Add(person01);
            peopleList.Add(person02);
            peopleList.Add(person03);
            

            Company company01 = new Company("Google", peopleList);

            PrintPetDetails(dog); // print Pet details
            Console.WriteLine();
            PrintPersonDetails(person02); // print Person details
            Console.WriteLine();
            PrintListaPeople(peopleList); // print a list of people
            Console.WriteLine();
            PrintCompanyDetails(company01); //
       
        }
        // method for printing
        public static void PrintPetDetails(Pet a) // print pet details
        {
            Console.WriteLine("Pet name: "+ a.name);
        }
        public static void PrintPersonDetails(Person p) // print person details
        {
            Console.WriteLine("Person name: " + p.name);
            Console.WriteLine("Person animal: " + p.personPet.name);
        }
        public static void PrintListaPeople(List<Person> listaPessoa) // Print the list of people
        {
            listaPessoa.ForEach(PrintPersonDetails);
        }
        public static void PrintCompanyDetails(Company b)
        {
            Console.WriteLine("Company Name: " + b.name);
            foreach(var item in b.people) // using the for each to go through the list (from another class)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.personPet.name);
            }
        }
        
    }
}
