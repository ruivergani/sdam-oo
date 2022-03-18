using System;
using System.Collections.Generic;
using System.Text;

namespace LectureAbstractClass
{
    class Budgie : Pet
    {
        public string ColourOfFeathers { get; }
     

        public Budgie(string name,
                      string ownerName,
                      string colourOfFeathers) : base(name, ownerName) // this make reference to the superclass attributes - initialise these parameters
        {
            ColourOfFeathers = colourOfFeathers;
        }
        // must implement the abstract ToString
        public override string ToString()
        {
            return $"Budgie '{name}' has {ColourOfFeathers} feathers.";
        }
    }
}
