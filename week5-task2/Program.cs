using System;
using System.Collections.Generic;

namespace week5_task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Week 5 - Task 1 Exercise");

            // List with person
            List<Person> listaComPessoas = new List<Person>();
            //Enqueue each Person object in the PersonQueue object
            PersonQueue filaDePessoas = new PersonQueue(listaComPessoas);
          
            char valueInput = GetAction(); // it will get a value from user
            while(valueInput != 'E')
            {
                // switch or if statment
                switch (valueInput)
                {
                    case 'L':
                        LeaveQueue(filaDePessoas.Dequeue());
                        break;
                    case 'J':
                        filaDePessoas.Enqueue(CreatePerson());
                        break;
                    default:
                        Console.WriteLine("Sorry, your action is not recognised");
                        break;
                }
                valueInput = GetAction(); // calling read line again
            }

        }
        // creating the functions/methods

        public static char GetAction()
        {
            Console.WriteLine("\nType...");
            Console.WriteLine("\tJ to join the queue");
            Console.WriteLine("\tL to leave the queue");
            Console.WriteLine("\tE to end the program");
            return Console.ReadLine().ToUpper()[0]; // Get Char
        }

        public static Person CreatePerson() // to use the type object you create the person
        {
            Person p = new Person(); // Create Person
            
            Console.WriteLine("Name: ");
            p.name = Console.ReadLine();
            Console.WriteLine("Age: ");
            p.age = Convert.ToInt32(Console.ReadLine());

            return p; // retornar a pessoa criada
        }
        public static void LeaveQueue(Person p)
        {
            if (p == null)
            {
                Console.WriteLine("The queue is empty");
            }
            else if(p.age < 15)
            {
                Console.WriteLine(p.name + " has left the queue, but is too young to enter the cinema.");
            }
            else
            {
                Console.WriteLine(p.name + " has left the queue and has entered the cinema.");
            }
        }
    }
}
