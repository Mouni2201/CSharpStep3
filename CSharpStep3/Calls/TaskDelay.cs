using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDelay
{
     class TaskDelayCls
    {
        static async Task Method1()
        {

            Console.WriteLine("Printing");
            await Task.Delay(4000);
            Console.WriteLine("Method1");


        }

        static async Task Method2()
        {
            await Task.Delay(3000);
            Console.WriteLine("Method2");
        }

        static async Task Main()
        {
            await TaskDelayCls.Method1();
            Console.WriteLine("Method1 is completed, now calling Method2");
            await TaskDelayCls.Method2();
            Console.WriteLine("Method2 is completed");
        }

        //caller

        //static void Main()
        //{
        //    Task t1 = TaskDelayCls.Method1();
        //    Task t2 = TaskDelayCls.Method2();


        //    t1.Wait();
        //    t2.Wait();
        //}
    }

    
}
