using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectMethods
{
    class Student
    {
        public string major;
        public double gpa;
        public string name;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;  
        }
        public bool HasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
