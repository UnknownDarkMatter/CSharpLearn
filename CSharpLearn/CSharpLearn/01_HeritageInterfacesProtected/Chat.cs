using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._01_HeritageInterfacesProtected
{
    class Chat : IAnimals
    {
        public string Parler()
        {
            return "Miaw";
        }
    }
}
