using System;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; //current date and time
            Console.WriteLine("Today: {0:s}", now.ToString("dd MMM yyyy HH:mm:ss"));
            Console.WriteLine("Tomorrow: {0:s}", now.AddDays(1).ToString("dd MMM yyyy HH:mm:ss"));
            Console.WriteLine("Yesterday: {0:s}", now.AddDays(-1).ToString("dd MMM yyyy HH:mm:ss"));

            DateTime janFirst = new DateTime(1970, 1, 1, 0, 0, 0); //y, m, d, h, m, s
            Console.WriteLine("\n1st Jan: {0:s}", janFirst.ToString("dd MMM yyyy HH:mm:ss"));
            Console.WriteLine("Day before: {0:s}", janFirst.AddDays(-1).ToString("dd MMM yyyy HH:mm:ss"));
            Console.WriteLine("Day after: {0:s}", janFirst.AddDays(1).ToString("dd MMM yyyy HH:mm:ss"));

            DateTime march28 = new DateTime(2020, 3, 28, 15, 05, 20); //y, m, d, h, m, s
            DateTime march27 = march28.AddHours(-24);
            DateTime march29 = march28.AddHours(24);
            Console.WriteLine("\n28th Mar: {0:s} {1:s}", march28.ToString("dd MMM yyyy HH:mm:ss"), march28.IsDaylightSavingTime() ? "BST" : "GMT");
            Console.WriteLine("Day before: {0:s} {1:s}", march27.ToString("dd MMM yyyy HH:mm:ss"), march27.IsDaylightSavingTime() ? "BST" : "GMT");
            Console.WriteLine("Day after: {0:s} {1:s}", march29.ToString("dd MMM yyyy HH:mm:ss"), march29.IsDaylightSavingTime() ? "BST" : "GMT");

            DateTime baseDate = new DateTime(0); //create with a number of milliseconds
            Console.WriteLine("\nBase date: {0:s}", baseDate.ToString("dd MMM yyyy HH:mm:ss"));
        }
    }
}
