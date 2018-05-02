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
            Student student0 = new Student("male", "blue", "american");
            Student student1 = new Student("female", "green", "british");
            Student student2 = new Student("male", "hazel", "cuban");
            newCourse.students[0] = student0;
            newCourse.students[1] = student1;
            newCourse.students[2] = student2;
            int studentCount = Student.CountStudents();

            // newCourse.students[0].gender = "male";
            // Console.WriteLine(newCourse.students[0].gender);

            // Instantiate at least one Teacher object in the Course object
            var teacher0 = new Teacher("female", "blue", "Spanish");
            //  var teacher0 = new Teacher("dr. miller", 31, "Italian");
            newCourse.teachers[0] = teacher0;
            // newCourse.teachers[0].name = "dr. murph";
            // newCourse.teachers[0].age = 45;
            // newCourse.teachers[0].classTaught = "MATH CLASS";

            // Using Console.WriteLine statements, output the following information to the console window:
            // The name of the program and the degree it contains
            // The name of the course in the degree
            // The count of the number of students in the course.
            Console.WriteLine("The program is {0} and it contains a {1}'s Degree", newProgram.UProgramName, newProgram.degrees[0].DegreeName);
            Console.WriteLine("The course in this degree is is {0}", newDegree.courses[0].CourseName);
            Console.WriteLine("There are {0} students", studentCount);
            // Console.WriteLine("Two students are: {0}, who lives in {1}. And {2}, who is in year {3}", newCourse.students[0].name, newCourse.students[0].dorm, newCourse.students[1].name, newCourse.students[1].Year);
            // Console.WriteLine("Their teacher is {0}, who teaches them {1}", newCourse.teachers[0].name, newCourse.teachers[0].classTaught);

            Console.WriteLine("Two students are: A {0}, who is {1}. And a {2}, who is {3}", newCourse.students[0].gender, newCourse.students[0].nationality, newCourse.students[1].gender, newCourse.students[1].nationality);
            // Console.WriteLine("Their teacher is a {0}, who is  {1}", newCourse.teachers[0].gender, newCourse.teachers[0].nationality);
            // Console.WriteLine("{0} is a {1}. She is {2}", newCourse.teachers[0].name, newCourse.teachers[0].gradeTest(), newCourse.teachers[0].age);
            Console.WriteLine("{0} is {1}. She teaches {2}", newCourse.teachers[0].name, newCourse.teachers[0].age, newCourse.teachers[0].classTaught);
        }
    }
}




// Create a Person base class with common attributes for a person. Remember to use encapsulation for these attributes.
// Applying proper OOP principles, make Person an abstract class
// Make your Student and Teacher classes inherit from the Person base class
// Modify your Student and Teacher classes so that they inherit the common attributes from Person
// Modify your Student and Teacher classes so they include characteristics specific to their type. For example, a Teacher object might have a GradeTest() method where a student might have a TakeTest() method.
// Run the same code in Program.cs from Module One's self assessment lab to create instances of your classes so that you can setup a single course that is part of a program and a degree path. Be sure to include at least one Teacher and an array of Students.
// Ensure the Console.WriteLine statements you included in Module One's self assessment lab still output the correct information.