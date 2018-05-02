using System;

namespace SelfTest
{
    public class Course
    {
        public string CourseName {get; set; }
        public Student[] students = new Student[3];
        public Teacher[] teachers = new Teacher[2];


        public Course(string _courseName)
        {
            this.CourseName = _courseName;
        }

    }
}



// public class Teacher
// {
//     // teacher implementation code here
// }

// public class Course
// {
//    Teacher courseTeacher;
//    // remaining Course implementation code here
// }

// The Course object should contain more than one Student object so 
// ensure that you create multiple Student objects inside the Course 
// object as well as Teacher objects. Each course may have more than one 
// teacher or teaching assistants and will have more than one Student. 
// For this lab you only need to create 3 students and at least one 
// teacher.

