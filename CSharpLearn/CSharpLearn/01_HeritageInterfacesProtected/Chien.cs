using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._01_HeritageInterfacesProtected
{
    public class Chien : IAnimals
    {
        public string Nom { get; set; }
        public Chien(string nom)
        {
            Nom = nom;
        }
        public string Parler()
        {
            return $"Ouaf, moi c'est {Nom}";
            //throw new NotImplementedException();
        }
        public void Mordre()
        {
            Console.WriteLine("le chien a mordu quelqu'un");
        }
    }
}
