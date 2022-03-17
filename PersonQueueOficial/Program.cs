using System;

namespace PersonQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonQueue q = new PersonQueue();
            Person p1 = new Person()
            {
                Name = "Person 1",
                Age = 11
            };
            Person p2 = new Person()
            {
                Name = "Person 2",
                Age = 21
            };
            Person p3 = new Person()
            {
                Name = "Person 3",
                Age = 31
            };

            q.Enqueue(p1);
            q.Enqueue(p2);
            q.Enqueue(p3);

            Console.WriteLine("\nRemove all Person objects from the queue...");
            while (!q.IsEmpty())
            {
                Console.WriteLine("\t" + q.Dequeue().Name);
            }
        }
    }
}
