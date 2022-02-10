using System;

namespace c_methods
{
    class Program
    {
        // creating a method
        static void MyMethod()
        {
            Console.WriteLine("I just got executed.");
        }
        static void MyMethod1(string fname)
        {
            Console.WriteLine(fname + " Username.");
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result; // return an integer value
        }
        static void Main(string[] args)
        {
            MyMethod(); // calling the method or function
            MyMethod(); // calling the method or function
            MyMethod1("Rui"); // calling method with parameters
            Console.WriteLine(cube(5)); // call method (return)
        }

    }
}
