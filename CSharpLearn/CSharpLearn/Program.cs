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
        static void Main(string[] args)
        {
            Console.WriteLine("#### Heritage ####");
            var heritageDemo1 = new HeritageDemo();
            var heritageDemo2 = new HeritageDemo();
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

            var exempleService8 = new CSharpLearn._08_Switch.ExempleService();
            exempleService8.Execute();




            Console.ReadLine();
        }
    }
}
