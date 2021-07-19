using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._03_Virtual
{
    public class ExempleService
    {
        public static void Execute()
        {
            Chien chien = new Chien();
            Console.WriteLine(chien.Aboyer());

            Chiot chiot = new Chiot();
            Console.WriteLine(chiot.Aboyer());

        }
    }
}
