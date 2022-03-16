using System;
using System.Collections.Generic;
using System.Text;

namespace week03_task2
{
    public class Budgie : Pet
    {
        public string colourOfFeathers { get; private set; }

        public Budgie(string name, string ownerName, string colourOfFeathers) : base(name, ownerName)
        {
            this.colourOfFeathers = colourOfFeathers;
        }
    }
}
