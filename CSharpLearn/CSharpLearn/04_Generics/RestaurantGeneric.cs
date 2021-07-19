using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._04_Generics
{
    public class RestaurantGeneric<TSpecialite> where TSpecialite : ISpecialiteFrench, new()
    {
        public TSpecialite Specialite;

        public RestaurantGeneric()
        {
            Specialite = new TSpecialite();
            Specialite.Plats = new List<string>();
        }

        public string ExecuterService()
        {
            var result = $"Service de plat avec {Specialite.NombreDeCouverts} couverts";
            foreach(var plat in Specialite.Plats)
            {
                result += ". " + plat;
            }
            return result;
        }
    }
}
