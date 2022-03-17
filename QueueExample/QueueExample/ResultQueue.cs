using System;
using System.Collections.Generic;

namespace QueueExample
{
    public class ResultQueue
    {
        private List<Result> queue = new List<Result>(); // lista

        public void Enqueue(Result result) // colocar na lista
        {
            queue.Add(result); // add to the list (method already done)
        }

        public Result Dequeue() // tirar da lista
        {
            // check if empty or not
            try
            {
                Result r = queue[0]; // store in R the first result in the queue
                queue.RemoveAt(0); // remove first position
                return r; // return removed value
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new Exception("Cannot dequeue because queue is empty");
            }
        }

        public bool IsEmpty()
        {
            return queue.Count == 0; // true or false
        }
    }
}
