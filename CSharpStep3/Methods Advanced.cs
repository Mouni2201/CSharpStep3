using System;
using System.Web;


namespace Method_Advanced
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }


    }

    class StudentOperations
    {
        //public static Student GetStudent()
        //{
        //    Student student = new Student()
        //    {
        //        Name = "Doe",
        //        Age = 25,
        //        Subject = "Chemistry"
        //    };
        //    return student;
        //}


        // public static Student GetStudent()
        //{
        //    Student student = new Student();
        //    student.Name = "John";
        //        student.Age = 20;
        //    student.Subject = "Maths";
        //    return student;
        //}


        public static Student GetStudent()
        {
            return new Student()
            {
                Name = "Harry",
                Age = 23,
                Subject = "JAVA"
            };
        }


    }

    class Program
    {
        static void Main()
        {
            Student singleStudent = StudentOperations.GetStudent();
            Console.WriteLine($"single student:{singleStudent.Name}, {singleStudent.Age}, {singleStudent.Subject}");
        }
    }






}




