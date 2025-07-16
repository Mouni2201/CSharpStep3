using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousCalls
{
    class WorkItems
    {
        public static async Task DocumentofStudentRamya()
        {
            var startTime = DateTime.Now;
            await Task.Delay(2000);   // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime.Milliseconds} ms.");

        }

        public static async Task DocumentofStudentRenu()
        {
            var startTime = DateTime.Now;
            await Task.Delay(1000);   // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the DoucumentationRenu Elapsed time: {elapsedTime.Milliseconds} ms.");

        }
        public static async Task DocumentofStudentJanu()
        {
            var startTime = DateTime.Now;
            await Task.Delay(3000);   // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the DoucumentationJanu Elapsed time: {elapsedTime.Milliseconds} ms.");

        }
    }

    class Trainer
    {
        public static async Task Works()
        {
            var startTime = DateTime.Now;
            Console.WriteLine("Concurrent Works - Running All Tasks Simultaneously");
            Task documentationTask = WorkItems.DocumentofStudentRamya();  // 5 seconds
            Task documentationTask1 = WorkItems.DocumentofStudentRenu();
            Task documentationTask2 = WorkItems.DocumentofStudentJanu(); // 3 seconds
            //await WorkItems.DocumentofStudentRenu(); //you can write like this also
            Console.WriteLine("Hello World");
            await documentationTask;
            await documentationTask1;
            await documentationTask2;
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Concurrent downloading completed. Total Elapsed Time : " +
                $"{elapsedTime.Milliseconds} ms");

            //var startTime = DateTime.Now;
            //Console.WriteLine("Concurrent Works - Running All Tasks Simultaneously");
            //await WorkItems.DocumentofStudentRamya();
            //await WorkItems.DocumentofStudentRenu();
            //await WorkItems.DocumentofStudentJanu();
            //var endTime = DateTime.Now;
            //var TotalTime = endTime - startTime;
            //Console.WriteLine($"All my works are completed{TotalTime}");


            //Console.WriteLine("Concurrent Works - Running All Tasks Simultaneously");
            //Task documentationTask = WorkItems.DocumentofStudentRamya();  // 5 seconds
            //Task documentationTask1 = WorkItems.DocumentofStudentRenu();
            //Task documentationTask2 = WorkItems.DocumentofStudentJanu();

            ////Task.WhenAll(documentationTask, documentationTask1, documentationTask2).Wait();

            //Task AllTasks = Task.WhenAll(documentationTask, documentationTask1, documentationTask2);
            ////AllTasks.Wait(); // Wait for all tasks to complete
            ////await AllTasks; // Await the completion of all tasks
            //await Task.WhenAll(documentationTask, documentationTask1, documentationTask2);






        }
    }


    class Program
    {
        static async Task Main()
        {
            await Trainer.Works();
        }
    }
}