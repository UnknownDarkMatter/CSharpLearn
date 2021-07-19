using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._04_Generics
{
    public class SpecialitePoulet : ISpecialiteFrench
    {
        public int NombreDeCouverts { get ; set; }
        public List<string> Plats { get; set; }
    }
}
