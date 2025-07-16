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
           
            Thread.Sleep(5000);
            Console.WriteLine("Begin the Process");
            Thread.Sleep(7000);

            Console.WriteLine("The End..");
            
        }
    }
}
