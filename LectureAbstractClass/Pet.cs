using System;
using System.Collections.Generic;
using System.Text;

namespace LectureAbstractClass
{
    public abstract class Pet // this is abstract class
    {
        public string name { get; }
        public string ownerName { get;  }

        public Pet(string name, string ownerName)
        {
            this.name = name;
            this.ownerName = ownerName;
        }
        // Abstract method DO NOT HAVE BODY - does not need a body method
        public abstract override string ToString(); //abstract: because I do not know precisely how to describe a Pet in a string
        

    }
}
