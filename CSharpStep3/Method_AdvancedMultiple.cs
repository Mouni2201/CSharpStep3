using Method_Advanced;
using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Method_AdvancedMultiple
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }
    }
    class StudentOperations
    {
        public static Student[] GetStudent()
        {
            //Student student1 = new Student();
            //    student1.Name = "Khushal";
            //student1.Age = 2;
            //student1.Subject = "Java";

            //Student student2 = new Student();
            //    student2.Name = "Medhansh";
            //student2.Age = 01;
            //student2.Subject = "Rhymes";

            //Student student3 = new Student();
            //    student3.Name = "Sahsra";
            //student3.Age = 10;
            //student3.Subject = "Science";

            ////string[] str = new string[];
            //Student[] students = new Student[] { student1, student2, student3 };
            //return students;


            //Another Way
            //Student[] students = new Student[] { student1, student2, student3 };
            //details add in student1, student2, student3 places 
            //Student[] students = new Student[]
            //{
            //    new Student ()
            //{
            //    Name = "Khushal",
            //    Age = 2,
            //    Subject = "Java"
            //},

            //     new Student ()
            //{
            //    Name = "Medhansh",
            //    Age = 01,
            //    Subject = "Rhymes"
            //},

            //      new Student ()
            //{
            //    Name = "Mouni",
            //    Age =25,
            //    Subject = "JAVASCRIPT"
            //}
            //    };
            //return students;


            //Another Way

            return new Student[]
            {
                new Student()
        {
            Name = "Khushal",
                Age = 2,
                Subject = "Java"
            },

                 new Student()
        {
            Name = "Medhansh",
                Age = 01,
                Subject = "Rhymes"
            },

                  new Student()
        {
            Name = "Mouni",
                Age = 25,
                Subject = "JAVASCRIPT"
            }
    };




    }
    public static Student GetStudent()
        {
            return new Student()
         {
            
            
                Name = "Khushal",
                Age = 2,
                Subject = "Java"
            };
     }

        public static Student Updatedstudent(Student student)
        {
            student.Subject = student.Subject + " - Advanced";
            return student;
        }
    }
    class Program
    {
        static void Main()
        {
            //insted of Stuudent[] we can use var and dynamic
            Student[] studentList = StudentOperations.GetStudent();
            Console.WriteLine("List of student");

            foreach (Student student in studentList)
            {
                Console.WriteLine($"{student.Name}, {student.Age}, {student.Subject}");
            }

            Student Kushal = StudentOperations.Updatedstudent(new Student(){
                Name = "Kushal",
                    Age = 2,
                Subject = "JAVA"
            });
            Console.WriteLine($"Now kushal subject is after Updatedstudent:{Kushal.Subject}");
        }
    }
}