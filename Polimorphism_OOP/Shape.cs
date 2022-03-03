using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism_OOP
{
    // Super Class
    public class Shape
    {
        public string name;
        

        // Constructor
        public Shape()
        {

        }
        // Variables
        public float area;

        // Functions (Methods)
        public float CalculateArea() // do not use static
        {
            return area;
        }
    }
}
