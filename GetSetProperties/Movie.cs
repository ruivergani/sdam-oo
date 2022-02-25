using System;
using System.Collections.Generic;
using System.Text;

namespace GetSetProperties
{
    class Movie
    {
        public string title;
        public string director;
        private string rating; // in order to use the get and set

        // the idea is to create get/set for every single attribute in order to manipulate and secure the system

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; // calling the set
        }
        // defining get/set
        public string Rating
        {
            get {
                return rating;
            }
            set {
                // example of Non-standard set method
                if (value == "G" || value == "PG") // only set the value to the attribute if satisfy the condition
                {
                    rating = value;
                }
                else
                {
                    rating = "Not declared.";
                }
            }
        }
    }
}
