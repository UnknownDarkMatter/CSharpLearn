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

            var exempleService4 = new CSharpLearn._04_Generics.ExempleService ();
            exempleService4.Execute();

            Console.ReadLine();
        }
    }
}
