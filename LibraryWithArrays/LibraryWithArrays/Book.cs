using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWithArrays
{
    public class Book
    {
        // public string <name> { private set; } : makes already private being able to use in other classes
        private static int nextId = 1; // use of static is one restricted to that Class
        public string Author { get; }
        public int Id { get; }
        public string ISBN { get; }
        public string Title { get; }
        private int numCopies; //not being used in method so is a field - because there is no get method

        private Copy[] copies; //an array called copies of the type class Copy[]

        public Book(string author, string iSBN, string title) // Control + . = generate constructor automatic
        {
            Id = nextId++; // assign value for ID and increment
            Author = author;
            ISBN = iSBN;
            Title = title;
            copies = new Copy[10]; // create an instance of the array size 10 - COPIES
            numCopies = 0;
        }
        public void AddCopy(Copy c)
        {
            // if is same size will increase
            if (numCopies == copies.Length)
            {
                // fix an array when the size is already fixed = solution is create a new array
                // solution to increase size of the array is to create a new one and assign old values to it
                Copy[] newCopies = new Copy[copies.Length + 5]; // new array in newCopies in case the length has reached 10
                for(int i = 0; i < numCopies; i++)
                {
                    newCopies[i] = copies[i];
                }
                copies = newCopies; //fixed array of length 15
            }
            copies[numCopies++] = c; // to perform the add_copy class
        }
        public Copy[] GetCopies()
        {
            Copy[] c = new Copy[numCopies]; // get a copy array = assing C
            for(int i = 0; i < numCopies; i++)
            {
                c[i] = copies[i];
            }
            return c; // return copies from array Copy[]
        }

    }
}
