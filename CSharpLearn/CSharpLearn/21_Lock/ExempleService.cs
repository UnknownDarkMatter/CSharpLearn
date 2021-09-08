using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLearn._21_Lock
{
    public class ExempleService
    {
        private static object _lockObject = new object();

        public void Execute()
        {
            Console.WriteLine("TEST SYNCHRONOUS");
            for(int i = 0; i < 5; i++)
            {
                var t = new Thread(BackgroundTaskSync);
                t.Start($"sync-thread-{i}");
            }

            Console.WriteLine("TEST ASYNCHRONOUS");
            for (int i = 0; i < 5; i++)
            {
                var t = new Thread(BackgroundTaskAsync);
                t.Start($"async-thread-{i}");
            }

        }

        private static void BackgroundTaskSync(object name)
        {
            lock (_lockObject)
            {
                Console.WriteLine($"{name} : Starting thread ...");
                Thread.Sleep(1000);
                Console.WriteLine($"{name} : Stopping thread ...");
            }
        }
        private static void BackgroundTaskAsync(object name)
        {
            Console.WriteLine($"{name} : Starting thread ...");
            Thread.Sleep(1000);
            Console.WriteLine($"{name} : Stopping thread ...");
        }

    }
}
