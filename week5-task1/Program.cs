using System;
using System.Collections.Generic;

namespace week5_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 5 - Task 1 Exercise");
            //Create three Person Objects
            Person person1 = new Person("Rui Neto", 21);
            Person person2 = new Person("Jaque", 22);
            Person person3 = new Person("Maria", 18);
            List<Person> listaComPessoas = new List<Person>(); // System.Generic

            //Enqueue each Person object in the PersonQueue object
            PersonQueue filaDePessoas = new PersonQueue(listaComPessoas);
            filaDePessoas.Enqueue(person1);
            filaDePessoas.Enqueue(person2);
            filaDePessoas.Enqueue(person3);


            Console.WriteLine("\nRemove all Person objects from the queue...");
            while (!filaDePessoas.isEmpty()) // enquanto nao esta vazio
            {
                Console.WriteLine("\t" + filaDePessoas.Dequeue().name);
            }

        }
        // create functions/methods

    }
}
