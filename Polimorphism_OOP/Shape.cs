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
        public Shape(int b)
        {

        }
        // Variables
        public float area;

        // Functions (Methods)
        public float CalculateArea() // do not use static
        {
            return area;
        }

        // function Overloading concept
        // if you pass different type parameters you can repeat the function 
        // diferent functionalities inside same methods
        public void draw()
        {

        }
        public void draw(int x)
        {

        }
        public void draw(float y)
        {

        }
        // Constructor or Function overloading - you can use same names but different parameters
    }
}
