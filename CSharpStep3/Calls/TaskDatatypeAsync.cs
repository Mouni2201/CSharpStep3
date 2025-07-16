using AsynchronousCalls;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousStudentTask
{
    class Tasks
    {
        public static async Task<string> CsharpCourse()
        {
            string CourseName = "Csharp";
            int DurationOfCourse = 10000;

            Console.WriteLine($"{CourseName} started to learn in july");
            await Task.Delay(DurationOfCourse);
            Console.WriteLine($"{CourseName} Completed to learn in July end in duration {DurationOfCourse / 1000}");

            return $"{CourseName} is completed in {DurationOfCourse / 1000}";
        }

        public static async Task<string> JavaSriptCourse()
        {
            string CourseName = "JavaScript";
            int DurationOfCourse = 9000;

            Console.WriteLine($"{CourseName} started to learn in july");
            await Task.Delay(DurationOfCourse);
            Console.WriteLine($"{CourseName} Completed to learn in July end in duration {DurationOfCourse / 1000}");

            return $"{CourseName} is completed in {DurationOfCourse / 1000}";
        }

        public static async Task<string> HTMLCourse()
        {
            string CourseName = "HTML";
            int DurationOfCourse = 5000;

            Console.WriteLine($"{CourseName} started to learn in july");
            await Task.Delay(DurationOfCourse);
            Console.WriteLine($"{CourseName} Completed to learn in July end in duration {DurationOfCourse / 1000}");

            return $"{CourseName} is completed in {DurationOfCourse / 1000}";
        }
    }

        class Trainer
        {
            public static async Task GroupTasksAsync()
            {
                //string firstTask = await Tasks.CsharpCourse();

                //string secondTask = await Tasks.JavaSriptCourse();

                //string thirdTask = await Tasks.HTMLCourse();

                //string[] AllTasks = new string[] { firstTask, secondTask, thirdTask };
                //foreach (string task in AllTasks)
                //{
                //    Console.WriteLine(task);
                //}

                Task<string> First = Tasks.CsharpCourse();
                Task<string> Second = Tasks.JavaSriptCourse();
                Task<string> Third = Tasks.HTMLCourse();

                string[] allResults = await Task.WhenAll(First, Second, Third);
                foreach(string result in allResults)
                {
                    Console.WriteLine(result);
                }
                
            }
        }
    
    class Program
    {
        static async Task Main()
        {
            await Trainer.GroupTasksAsync();
        }
    }
}
