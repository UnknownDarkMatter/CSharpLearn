using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._05_DisposeUsing
{
    public class ExempleService
    {
        internal void Execute()
        {
            using(var monComponentDisposable = new MonDisposableComponent())
            {
                Console.WriteLine("J'utilise mon Component");

                monComponentDisposable.Parler();
            }

            try
            {
                using (var monComponentDisposable = new MonDisposableComponent())
                {
                    Console.WriteLine("J'utilise mon Component");

                    monComponentDisposable.Test();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"le component a levé une exception : {ex.Message}");
            }

        }
    }
}
