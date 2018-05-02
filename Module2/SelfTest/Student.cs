using System;

namespace SelfTest
{
    // Declaring the Car() Class
    // This class has 3 properties: Color, Year, and Mileage
    public class Student
    {
        // Defining properties
        public string name { get; set; }
        public int Year { get; set; }
        public string dorm { get; set; }


        //Adding Constructore
        public Student(string name, int Year, string dorm)
        {
            this.name = name;
            this.Year = Year;
            this.dorm = dorm;
            // Every time the constructor runs, increment "instances"
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