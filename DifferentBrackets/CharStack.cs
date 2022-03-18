using System;
using System.Collections.Generic;

namespace DifferentBrackets
{
    public class CharStack
    {
        private List<char> stack;

        public CharStack()
        {
            stack = new List<char>();
        }

        public char Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }

            int index = stack.Count - 1;
            char c = stack[index];
            stack.RemoveAt(index);
            return c;
        }

        public void Push(char c)
        {
            stack.Add(c);
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }
    }
}
