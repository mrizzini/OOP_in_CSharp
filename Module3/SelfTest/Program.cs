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
            // Console.WriteLine("hey{0} ", student1);
            student1.LogWriter("text.txt");
            student1.WriteLine("text.txt");
            student1.Dispose();

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




// Choose the proper class in the hierarchy that will implement the IDisposable interface
// Implement the IDisposable interface in that class. Refer back to the text content and use msdn.microsoft.com to research IDisposable for code samples if you are still not clear on how to implement it.
// Ensure that you class has a destructor
// Ensure that in your destructor you check for the existence of the proper object
// Call the appropriate methods, in the proper locations, to close your file before your object is destroyed.
// Ensure that you have used the dispose method for the StreamReader object
// Signal to the .NET runtime that your application is ready for resource management by calling the proper method on the correct object. Note that the object and method are not named here but are left up to you to determine the proper options.
// Run your code and ensure it compiles and runs correctly.