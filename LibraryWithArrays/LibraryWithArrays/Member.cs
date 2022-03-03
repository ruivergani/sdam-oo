using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTests
{
    public class Member // use public to make accessible to the others
    {
        private static int nextId = 1; // belongs to the class (not object)
        
        public int Id { get;  }
        public string Name { get; }

        public Member(string aName)
        {
            Id = nextId++; //assign automatic ID and increment it
            Name = aName;
        }
    }
}
