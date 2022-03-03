using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism_OOP
{
    class Circle : Shape // making child of Super Class shape
    {
        // to use float = type f (in the end)
        public float radius = 5.0f; // f to identify as float
        public float pi = 3.1459f; // could use as const

        public new float CalculateArea() // override of the function (using with different formula)
        {
            return pi * radius * radius;
        }
    }
}
