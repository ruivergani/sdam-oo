using System;

namespace Polimorphism_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise about polymorphism.");

            Shape myShape = new Shape();
            Rectangle myRectangle = new Rectangle(); // creating object of the class
            Circle myCircle = new Circle();

            float area1 = myRectangle.CalculateArea();
            float area2 =  myCircle.CalculateArea();

            Console.WriteLine("Area of Rectangle: " + area1);
            Console.WriteLine("Area of Circle: " + area2);


        }
    }
}
