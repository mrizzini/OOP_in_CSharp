using System;

namespace SelfTest
{
    public class Teacher
    {
        // Defining properties
        public string name { get; set; }
        public int age { get; set; }
        public string classTaught { get; set; }

        //Adding another Constructor
        public Teacher(string name, int age, string classTaught)
        {
            this.name = name;
            this.age = age;
            this.classTaught = classTaught;

        }

    }
}