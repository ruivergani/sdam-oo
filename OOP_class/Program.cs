using System;

namespace OOP_class
{
    class MyClass   // The class
    {
     // Class members
     string color = "red"; // field
     int maxSpeed = 200;
     public void fullThrottle()     // method/function
     {
        Console.WriteLine("The car is going as fast as it can.");
     }
     
        static void Main(string[] args)     // Main
        {
            MyClass Ford = new MyClass();    // object in order to use the variables/fields
            Ford.color = "yellow";
            Ford.maxSpeed = 350;
            Console.WriteLine(Ford.color + Ford.maxSpeed); // print new attributes
            Ford.fullThrottle(); // call object methods 
        }
    }

}
