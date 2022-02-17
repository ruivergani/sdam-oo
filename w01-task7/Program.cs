using System;
using w01_task7_class;

namespace w01
{
    class Program
    {
        static void Main(string[] args){
            PrintMessageToConsole print = new PrintMessageToConsole(); // create an instance of the class
            print.MyName = "Rui Neto"; // using class variables
            Console.WriteLine(print.MyName);
        }
    }
}
