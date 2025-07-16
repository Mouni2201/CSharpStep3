using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSleep
{
    class ThreadSleep
    {
        static void Main()
        {
           
            Console.WriteLine("Start the process");
            var startTime = DateTime.Now;
            Thread.Sleep(5000);
            Console.WriteLine("End the Process");
            
        }
    }
}
