using System;
using System.Threading;
using System.Threading.Tasks;

namespace DelayTask
{
     class DelayAsyncAndAwait
    {
        static async Task Main()
        {
            Console.WriteLine("Start the Process");
            await Task.Delay(5000);
            Console.WriteLine("Begin the Process");
            await Task.Delay(7000);
            Console.WriteLine("The End..");
        }
    }
}
