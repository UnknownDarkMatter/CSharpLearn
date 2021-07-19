using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._01_HeritageInterfacesProtected
{
    public class Chiot: Chien
    {
        public string NomChiot { get; set; }
        private string _jouet;
        public string Jouet {
            get
            {
                return _jouet;
            }
            set
            {
                _jouet = value;
            }
        }

        public string Collier;

        public Chiot(string nom, string collier) : base(nom)
        {
            _jouet = "balle";
            Collier = collier;

        }


    }
}
