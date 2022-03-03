using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism_OOP
{
    class Rectangle : Shape
    {
        public float length = 5.0f;
        public float width = 5.0f;

        public virtual new float CalculateArea() // this is the polymorphism happening
        {
            return 2 * length * width;
        }
    }
}
