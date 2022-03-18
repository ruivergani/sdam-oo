using System;
using System.Collections.Generic;
using System.Text;

namespace LectureAbstractClass
{
    class Pet // this is abstract class
    {
        public string name { get; }
        public string ownerName { get;  }

        public Pet(string name, string ownerName)
        {
            this.name = name;
            this.ownerName = ownerName;
        }
    }
}
