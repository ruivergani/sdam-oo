using System;

namespace QueueExample
{
    public class Result
    {
        public int num1 { get; }
        public int num2 { get; }
        public char op { get; }
        public double Value { get; private set; }

        public Result(int num1, int num2, char op) // constructor
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
            SetValue(); // calling function
        }

        private void SetValue()
        {
            switch (op)
            {
                case '+':
                    Value = num1 + num2;
                    break;
                case '-':
                    Value = num1 - num2;
                    break;
                case '*':
                    Value = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        throw new Exception("The second integer cannot be zero when dividing");
                    }
                    Value = num1 / num2;
                    break;
                default: // if not any of the above
                    throw new Exception("Operator not recognised");
                    // even this needs a break
            }
        }

        public override string ToString() // convert to String the values
        {
            // Override this string method and use it to call the Console.WriteLine
            return 
                string.Format(
                    "{0, 3}  {1} {2, 3}  =  {3}",
                    num1,
                    op,
                    num2,
                    Value);
        }
    }
}
