using System;
using System.Collections.Generic;
using System.Text;

namespace week5_task1
{
    public class PersonQueue
    {
        private List<Person> fila = new List<Person>(); // new object list type Person


        public PersonQueue(List<Person> listas) // constructor
        {
            this.fila = listas;
        }

        // creating methods
        public void Enqueue(Person person) // add to list
        {
            fila.Add(person);
        }
        public Person Dequeue()
        {
            try
            {
                Person p = fila[0];
                fila.RemoveAt(0); // remove at 0
                return p;
            }
            catch
            {
                throw new Exception("Cannot dequeue because queue is empty.");
            }
        }
        public bool isEmpty()
        {
            return fila.Count == 0; // true or false
        }
    }
}
