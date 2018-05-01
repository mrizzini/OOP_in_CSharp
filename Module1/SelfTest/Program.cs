using System;

namespace SelfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            // Instantiate a UProgram object called Information Technology.
            UProgram newProgram = new UProgram("Information Technology");

            // Instantiate a Degree object, such as Bachelor, inside the UProgram object.
            Degree newDegree = new Degree("Bachelor");
            newProgram.degrees[0] = newDegree;

            // Instantiate a Course object called Programming with C# inside the Degree object.
            Course newCourse = new Course("Programming with C#");
            newDegree.courses[0] = newCourse;

            // Instantiate your three students in this Course object.
            Student student0 = new Student("mike", 4, "mcdermott");
            Student student1 = new Student("mary", 2, "ray hall");
            Student student2 = new Student("hank", 3, "mcvinney");
            newCourse.students[0] = student0;
            newCourse.students[1] = student1;
            newCourse.students[2] = student2;
            int studentCount = Student.CountStudents();

            // Instantiate at least one Teacher object in the Course object
            var teacher0 = new Teacher("Dr. Murph", 45, "Spanish");
            newCourse.teachers[0] = teacher0;

            // Using Console.WriteLine statements, output the following information to the console window:
            // The name of the program and the degree it contains
            // The name of the course in the degree
            // The count of the number of students in the course.
            Console.WriteLine("The program is {0} and it contains a {1}'s Degree", newProgram.UProgramName, newProgram.degrees[0].DegreeName);
            Console.WriteLine("The course in this degree is is {0}", newDegree.courses[0].CourseName);
            Console.WriteLine("There are {0} students", studentCount);
            Console.WriteLine("Two students are: {0}, who lives in {1}. And {2}, who is in year {3}", newCourse.students[0].name, newCourse.students[0].dorm, newCourse.students[1].name, newCourse.students[1].Year);
            Console.WriteLine("Their teacher is {0}, who teaches them {1}", newCourse.teachers[0].name, newCourse.teachers[0].classTaught);

        }
    }
}




