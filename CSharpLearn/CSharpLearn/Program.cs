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

        static IEnumerator<int> GetInts()
        {
            Console.WriteLine("first");
            yield return 1;

            Console.WriteLine("second");
            yield return 2;
        }


        static async Task Main(string[] args)
        {

            //var maDate = DateTime.Now;
            //maDate = new DateTime(2021, 09, 21, 10, 59, 23);
            //maDate = maDate.AddDays(1);
            //maDate = maDate;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bienvenue dans le C# !");
            Console.ResetColor();

            //IEnumerable<int> GenerateWithoutYield()
            //{
            //    var i = 0;
            //    var list = new List<int>();
            //    while (i < 5)
            //        list.Add(++i);
            //    return list;
            //}

            //foreach (var number in GenerateWithoutYield())
            //{
            //    Console.WriteLine("sans yield" + number);
            //}

            ////////////////////////
            //IEnumerable<int> GenerateWithYield()
            //{
            //    var i = 0;
            //    while (i < 5)
            //        yield return ++i;
            //}
            //foreach (var number in GenerateWithYield())
            //{
            //    Console.WriteLine("avec yield" + number);
            //}


            //https://www.c-sharpcorner.com/uploadfile/mahesh/backgroundworker-in-C-Sharp/

            IEnumerator<int> intsEnumerator = GetInts(); // print nothing
            Console.WriteLine("...");                    // print "..."

            intsEnumerator.MoveNext();                   // print "first"
            Console.WriteLine(intsEnumerator.Current);   // print 1

            intsEnumerator.MoveNext();                   // print "first"
            Console.WriteLine(intsEnumerator.Current);   // print 1


            Console.WriteLine("#### Heritage ####");
            //var heritageDemo1 = new HeritageDemo();
            //var heritageDemo2 = new HeritageDemo();
            //heritageDemo2.Execute();

            //Console.WriteLine("#### virtual/overide + static ####");
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


            //erreur de runtime lors de l'execution de l'assembly
            //object toto = 1;
            //object titi = "2";
            //int result = (int)toto + (int)titi;

            //var exempleService = new _20_AsyncAwait.ExempleService();
            //await exempleService.Execute();

            //var exempleService = new _21_Lock.ExempleService();
            //exempleService.Execute();


            //var exempleService = new _29_Bitwise.ExempleService();
            //exempleService.Execute();

            //var exempleService = new _30_Delegate.ExampleService();
            //exempleService.Execute(new _30_Delegate.ExampleService.MonActionDelegate(exempleService.MonAction));
            //exempleService.Execute(new _30_Delegate.ExampleService.MonActionDelegate((monArg) => { Console.WriteLine($"This is a Lambda delegate with arg {monArg}"); }));

            Console.ReadLine();
        }
    }
}
