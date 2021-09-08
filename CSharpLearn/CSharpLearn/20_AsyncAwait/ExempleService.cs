using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._20_AsyncAwait
{
    /// <summary>
    /// Le mot clef lock ne s'utilise pas avec les async await
    /// </summary>
    public class ExempleService
    {
        public async Task Execute()
        {
            Console.WriteLine("Code Sync ...");

            await ExecureCodeSync();

            await ExecureCodeAsync();
        }

        private static async Task ExecureCodeSync()
        {
            for(int i = 0; i < 5 ; i++)
            {
                await OutputTextSync($"TEST SYNC : Itération {i}");
            }
        }

        private static async Task ExecureCodeAsync()
        {
            for (int i = 0; i < 5; i++)
            {
                OutputTextAsync($"TEST ASYNC : Itération {i}");
            }
        }

        private static async Task OutputTextSync(string message)
        {
            Console.WriteLine("TEST SYNC : OutputTextSync start");
            Console.WriteLine(message);
            await Task.Delay(1000);
            Console.WriteLine("TEST SYNC : OutputTextSync end");
        }

        private static async Task OutputTextAsync(string message)
        {
            Console.WriteLine("TEST ASYNC : OutputTextAsync start");
            Console.WriteLine(message);
            await Task.Delay(1000);
            Console.WriteLine("TEST ASYNC : OutputTextAsync end");
        }
    }
}
