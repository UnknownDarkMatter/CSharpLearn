using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._04_Generics
{
    public class SpecialiteSoupe : ISpecialiteFrench
    {
        public int NombreDeCouverts { get ; set; }
        public List<string> Plats { get; set; }
        public bool AvecSoupeOignon{ get; set; }

        public string ServirSoupe()
        {
            //operateur ternaire "? :"
            return AvecSoupeOignon ? "Service de soupe a l'oignon" : "Service de soupe de base";
        }
    }
}
