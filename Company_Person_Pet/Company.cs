using System;
using System.Collections.Generic;
using System.Text;

namespace Company_Person_Pet
{
    public class Company
    {
        public string name { get; set; }

        public List<Person> people = new List<Person>(); 
        
        public Company(string aName, List<Person> aPeople)
        {
            name = aName;
            people = aPeople; // calling list of person in the constructor
        }
    }
}
