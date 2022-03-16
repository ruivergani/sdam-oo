using System;
using System.Collections.Generic;
using System.Text;

namespace week03_task3
{
    class Budgie
    {
        public string colourOfFeathers { get; private set; }

        public Budgie(string name, string ownerName, string colourOfFeathers) : base(name, ownerName)
        {
            this.colourOfFeathers = colourOfFeathers;
        }
    }
}
