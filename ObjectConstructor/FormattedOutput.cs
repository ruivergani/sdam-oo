using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectConstructor
{
    class FormattedOutput
    {
        // Constructor
        public FormattedOutput() // same name as Class (not return type void/int)
        {
            int i;
            string name;
            float salary;
        }
       public void PrinteMessageHeader() // function
        {
            Console.WriteLine("Hello World. "); 
        }
    }
}
