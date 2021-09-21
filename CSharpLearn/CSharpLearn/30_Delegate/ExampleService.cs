using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._30_Delegate
{
    public class ExampleService
    {
        public delegate void MonActionDelegate(string monArg);


        public void Execute(MonActionDelegate monActionDelegate)
        {
            monActionDelegate.Invoke("toto");
        }

        public void MonAction(string monArg)
        {
            Console.WriteLine($"quelque chose est fait avec l'argument {monArg}");
        }
    }
}
