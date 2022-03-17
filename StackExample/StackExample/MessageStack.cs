using System.Collections.Generic;

namespace StackExample
{
    public class MessageStack
    {
        private List<Message> stack = new List<Message>();

        public void Push(Message msg) // adding to it
        {
            stack.Add(msg);
        }

        public Message Pop() // removing from the last
        {
            Message msg = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return msg;
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }
    }
}
