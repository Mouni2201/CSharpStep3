
//using System;
//using System.Runtime.CompilerServices;
//using System.Threading;
//using System.Threading.Tasks;

//namespace StudentTask

//{
//    class TaskforStudent
//    {
//        public static async Task<int> StudentID()
//        {
//            await Task.Delay(2000);
//            return 10;
//        }

//        public static async Task<string> StudentDetails(int studentID)
//        {
//            await Task.Delay(3000);
//            return $"Student #{studentID}: John Doe, enrolled in Computer Science";
//        }

//    }

//    class Trainer
//    {
//        public static async Task Tracking()
//        {
//            int Id = await TaskforStudent.StudentID();
//            string details = await TaskforStudent.StudentDetails(5);




//        }




//    }

//    class Program
//    {
//        static async Task Main()
//        {
//            await Trainer.Tracking();
//        }
//    }


//}
