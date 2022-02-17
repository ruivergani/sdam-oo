using System;

namespace Car_OOP
{
    class Car // class declaration (Car class)
    {
        string model;
        string color;
        int year;

        //public: only accessed by objects | static: can be accessed without creating an object of the class
        public void accelerate() // creating object method
        {
            Console.WriteLine("The car is full throttle.");
        }

        static void Main(string[] args)
        {
            Car Ford = new Car(); // declaring object called Ford
            Ford.color = "red";
            Ford.model = "Mustang";
            Ford.year = 2021;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.color);
            Ford.accelerate(); // calling the object method using the object

        }
    }
}
