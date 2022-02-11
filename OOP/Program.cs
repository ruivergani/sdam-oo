using System;

namespace OOP
{
    class Car      // Class (object is created from a class)
    {
        public string color = "red"; // attribute    variables/fields inside class car      // public: make available for use other variables
        static void Main(string[] args)
        {
            Car myObj = new Car();  // create an Object of Car
            Car myObject2 = new Car();
            Console.WriteLine("New object: ", myObject2.color);
            Console.WriteLine("Object 1: ", myObj.color);
        }
    }
}
