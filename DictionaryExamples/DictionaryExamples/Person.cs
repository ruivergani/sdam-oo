using System;

namespace DictionaryExamples
{
    class Person
    {
        public int PersonId { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return PersonId + ": " + Name;
        }
    }
}
