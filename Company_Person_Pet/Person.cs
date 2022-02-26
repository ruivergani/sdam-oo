using System;
using System.Collections.Generic;
using System.Text;

namespace Company_Person_Pet
{
    public class Person
    {
        public string name { get; set; }
        public Pet personPet {get;} //Pet property from Pet Class

       

        public Person(string aName, Pet PersonPet) //constructor Person
        {
            name = aName;
            personPet = PersonPet;
        }
    }
}
