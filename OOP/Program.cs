using System;

namespace OOP
{
    class Car      // Class (object is created from a class)
    {
        string color = "red"; // attribute    variables/fields inside class car
        static void Main(string[] args)
        {
            Car myObj = new Car();  // create an Object of Car
            Console.WriteLine(myObj.color);
        }
    }
}
