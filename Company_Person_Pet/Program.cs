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
            Person person03 = new Person("Jordan", null);

            List<Person> peopleList = new List<Person>()
            {
                person02, person01
            };

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
        public static void PrintPetDetails(Pet a)
        {
            Console.WriteLine("Pet name: "+ a.name);
        }
        public static void PrintPersonDetails(Person p)
        {
            Console.WriteLine("Person name: " + p.name);
            Console.WriteLine("Person animal: " + p.personPet.name);
        }
        public static void PrintListaPeople(List<Person> listaPessoa)
        {
            listaPessoa.ForEach(PrintPersonDetails);
        }
        public static void PrintCompanyDetails(Company b)
        {
            Console.WriteLine("Company Name: " + b.name);
            // THE ISSUE IS HOW CAN I print the company details (basically the list of the company that includes Person details)
            List<Person> listaDePessoas = b.people;
            Console.WriteLine("Lista da compania: ");
            Console.WriteLine(listaDePessoas.Count); // could not print but the count is working
        }
        
    }
}
