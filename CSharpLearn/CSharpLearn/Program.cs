using CSharpLearn._01_HeritageInterfacesProtected;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    class Program
    {



        static async Task Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bienvenue dans le C# !");
            Console.ResetColor();

            Console.WriteLine("Décommentez du code pour voir ce qu'il fait");

            //CSharpLearn._03_Virtual.ExempleService.Execute();

            //var exempleService4 = new CSharpLearn._04_Generics.ExempleService ();
            //exempleService4.Execute();

            //var exempleService5 = new CSharpLearn._04_StructRefOut.ExempleService();
            //exempleService5.Execute();

            //var exempleService5 = new CSharpLearn._04_TryCatch.ExempleService();
            //exempleService5.Execute();

            //var exempleService6 = new CSharpLearn._05_DisposeUsing.ExempleService();
            //exempleService6.Execute();

            //var exempleService7 = new CSharpLearn._05_Types.ExempleService();
            //exempleService7.Execute();

            //var exempleService8 = new CSharpLearn._08_continue_break.ExempleService();
            //exempleService8.Execute();

            //var exempleService8 = new CSharpLearn._08_Switch.ExempleService();
            //exempleService8.Execute();

            //var exempleService9 = new CSharpLearn._09_LinqPipeline.ExempleService();
            //exempleService9.Execute();

            //var exempleService = new _23_ReflexionGetType.ExempleService();
            //exempleService.Execute();

            //var exempleService = new _20_AsyncAwait.ExempleService();
            //await exempleService.Execute();

            //var exempleService = new _20_BackgroundWorker.ExempleService();
            //exempleService.Execute();

            //var exempleService = new _21_Lock.ExempleService();
            //exempleService.Execute();


            //var exempleService = new _29_Bitwise.ExempleService();
            //exempleService.Execute();

            //var exempleService = new _30_Delegate.ExampleService();
            //exempleService.Execute(new _30_Delegate.ExampleService.MonActionDelegate(exempleService.MonAction));
            //exempleService.Execute(new _30_Delegate.ExampleService.MonActionDelegate((monArg) => { Console.WriteLine($"This is a Lambda delegate with arg {monArg}"); }));

            //var exempleService = new _31_YieldReturn.ExempleService();
            //exempleService.Execute();

            Console.ReadLine();
        }
    }
}
