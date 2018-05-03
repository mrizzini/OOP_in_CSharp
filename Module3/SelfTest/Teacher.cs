using System;

namespace SelfTest
{
    internal class Teacher : Person
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

        // public Teacher(String name) : base(name, 75000)
        // {

        // }

        public string gradeTest()
        {
            return "Teacher is currently grading a test";
        }

        public Teacher(string gender, string eyeColor, string nationality)
        {
            this.gender = gender;
            this.eyeColor = eyeColor;
            this.nationality = nationality;
            // this.gradeTest = gradeTest();
        }


    }
}

        // // Calls upon base-class (Employee Class) constructor from within derived class (TechnicalEmployee Class)
        // // Sets baseSalary to 75000 for all TechnicalEmployee objects
        // public TechnicalEmployee(String name) : base(name, 75000)
        // {

// Modify your Student and Teacher classes so that they inherit the common attributes from Person