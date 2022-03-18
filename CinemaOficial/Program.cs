using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonQueue q = new PersonQueue();

            char action = GetAction();

            while (action != 'E')
            {
                switch (action)
                {
                    case 'L':
                        LeaveQueue(q.Dequeue());
                        break;
                    case 'J':
                        q.Enqueue(CreatePerson());
                        break;
                    default:
                        Console.WriteLine("Sorry, your action is not recognised");
                        break;
                }
                action = GetAction();
            }
        }

        private static char GetAction()
        {
            Console.WriteLine("\nType...");
            Console.WriteLine("\tJ to join the queue");
            Console.WriteLine("\tL to leave the queue");
            Console.WriteLine("\tE to end the program");
            Console.Write("Action? > ");
            return Console.ReadLine().ToUpper()[0];
        }

        private static Person CreatePerson()
        {
            Person p = new Person();

            Console.Write("Name of person joining the queue: > ");
            p.Name = Console.ReadLine();

            Console.Write("Age of person joining the queue: > ");
            p.Age = Convert.ToInt32(Console.ReadLine());

            return p;
        }

        private static void LeaveQueue(Person p)
        {
            if (p == null)
            {
                Console.WriteLine("The queue is empty");
            }
            else if (p.Age < 15)
            {
                Console.WriteLine(p.Name + " has left the queue, but is too young to enter the cinema");
            }
            else
            {
                Console.WriteLine(p.Name + " has left the queue and has entered the cinema");
            }
        }
    }
}
