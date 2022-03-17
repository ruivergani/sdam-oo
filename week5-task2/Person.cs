using System;
using System.Collections.Generic;
using System.Text;

namespace week5_task2
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(string name, int age) // constructor
        {
            this.name = name;
            this.age = age;
        }
        public Person()
        {
            // just empty constructor
        }

        public override string ToString()
        {
            return base.ToString(); // code the override here
        }
    }
}
