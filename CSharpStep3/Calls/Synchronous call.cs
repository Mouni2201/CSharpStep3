using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronousCall
{
    class Documents
    {
        public static void DocumentofStudentRamya()
        {
            var startTime = DateTime.Now;
            Thread.Sleep(2000);

            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the documentation elapsed time: {elapsedTime} ms");
        }


        public static void DocumentofStudentRenu()
        {
            var startTime = DateTime.Now;
            Thread.Sleep(3000);

            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the documentation elapsed time: {elapsedTime} ms");
        }

        public static void DocumentofStudentJanu()
        {
            var startTime = DateTime.Now;
            Thread.Sleep(5000);

            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the documentation elapsed time: {elapsedTime} ms");
        }
    }

    class Teacher
    {
        public static void Works()
        {
            Console.WriteLine($"Sequential work - step by step");

            var CompletionStartTime = DateTime.Now;

            Documents.DocumentofStudentRamya();
            Documents.DocumentofStudentRenu();
            Documents.DocumentofStudentJanu();

            var CompletionEndTime = DateTime.Now;
            var SequentialElapsedTime = CompletionEndTime - CompletionStartTime;

            Console.WriteLine($"Sequential downloading completed. Total Elapsed Time : " +
                $"{SequentialElapsedTime.Milliseconds} ms");

        }
    }

    class Program
    {
        static void Main()
        {
            Teacher.Works();
        }
    }
}
