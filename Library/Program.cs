using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book(); // object (instance of the class)
            Book1.title = "Clean Code.";
            Book1.author = "Rui Neto";

            Book Book2 = new Book(); // object (instance of the class)
            Book2.title = "Lord of Rings.";
            Book2.author = "Jhonatan";
        }
    }
}
