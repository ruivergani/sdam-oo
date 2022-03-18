using System;
using System.Collections.Generic;

namespace Cinema
{
    public class PersonQueue
    {
        private List<Person> queue;

        public PersonQueue()
        {
            queue = new List<Person>();
        }

        public Person Dequeue()
        {
            try
            {
                Person p = queue[0];
                queue.RemoveAt(0);
                return p;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Enqueue(Person p)
        {
            queue.Add(p);
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }
    }
}
