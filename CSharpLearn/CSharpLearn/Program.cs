using CSharpLearn._01_HeritageInterfacesProtected;
using CSharpLearn._03_Virtual;
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
            heritageDemo2.Execute();

            Console.WriteLine("#### virtual/overide + static ####");
            ExempleService.Execute();


            Console.ReadLine();
        }
    }
}
