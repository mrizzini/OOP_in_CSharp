using System;

namespace SelfTest
{
    // Declaring the Student() Class, inheriting from Person
    internal class Student : Person
    {
        // Defining properties
        public string name { get; set; }
        public int Year { get; set; }
        public string dorm { get; set; }


        // Adding Constructor
        public Student(string name, int Year, string dorm)
        {
            this.name = name;
            this.Year = Year;
            this.dorm = dorm;
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        public string takeTest()
        {
            return "Student is currently taking a test";
        }


        public Student(string gender, string eyeColor, string nationality)
        {
            this.gender = gender;
            this.eyeColor = eyeColor;
            this.nationality = nationality;
            // this.takeTest = takeTest();
            instances++;
        }

        // Creates integer variable called "instances" and assigns value to 0
        private static int instances = 0;

        public static int CountStudents()
        {
            return instances;
        }
    }
}