using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageStack stack = new MessageStack();
            Random rand = new Random();
            List<string> people = CreatePersonList();
            string[] message = CreateMessagesArray();

            int numPeople = people.Count;
            for (int i = 0; i < numPeople; i++)
            {
                int personIndex = rand.Next(0, people.Count);
                string name = people[personIndex];
                people.RemoveAt(personIndex);

                int msgIndex = rand.Next(0, message.Length);
                DateTime date = DateTime.Now.AddDays(rand.Next(1, 20));

                Message msg = new Message(name, message[msgIndex], date);
                //Console.WriteLine(msg);
                stack.Push(msg);
            }

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop().ToString());
            }
        }

        private static List<string> CreatePersonList()
        {
            List<string> list = new List<string>(10);

            for (int i = 1; i < 11; i++)
            {
                list.Add("Person " + i);
            }

            return list;
        }

        private static string[] CreateMessagesArray()
        {
            string[] msgs = { "Message 1", "Message 2", "Message 3", "Message 4", "Message 5" };
            return msgs;
        }
    }
}
