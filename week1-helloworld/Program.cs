using System; /* same as import in python */

namespace week1_helloworld /* namespace is a collection of classes */
{
    class Program
    {
        static void Main(string[] args) /* main method is the first one to execute */
        {
            Console.WriteLine("Hello World!"); /* output statement */
            Console.WriteLine("Rui good afternoon.");

            Console.WriteLine("\n \t'{0}'", "Hello again");
            Console.Write("\n\t\t\t'{0, 20}'\n", "Hello once more");
        }
    }
}
