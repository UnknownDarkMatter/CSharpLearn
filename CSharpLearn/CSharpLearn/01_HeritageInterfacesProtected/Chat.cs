using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._01_HeritageInterfacesProtected
{
    class Chat : IAnimals
    {
        public string Nom { get; set; }
        public Chat(string nom) 
        {
            Nom = nom;
        }
        public string Parler()
        {
            return "Miaw, je suis " + Nom;
        }


    }
}
