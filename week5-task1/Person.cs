using System;
using System.Collections.Generic;
using System.Text;

namespace week5_task1
{
    public class Person
    {
        public string name { get; private set; }
        public int age { get; private set; }

        public Person(string name, int age) // constructor
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return base.ToString(); // code the override here
        }
    }
}
