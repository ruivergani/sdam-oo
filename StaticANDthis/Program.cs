using System;

namespace StaticANDthis
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount); // I can only call here because of being object of the class - STATIC
            // Console.WriteLine(Song.artist); does not work without using an object
            // Console.WriteLine is independant of the object you do not need to create an object to use a method of the class Console
        }
    }
}
