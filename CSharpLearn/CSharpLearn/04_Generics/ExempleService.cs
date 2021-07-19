using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._04_Generics
{
    class ExempleService
    {
        public void Execute()
        {
            //erreur
            //var restaurant2 = new RestaurantGeneric<SpecialiteNem>();

            var restaurant1 = new RestaurantGeneric<SpecialitePoulet>();
            restaurant1.Specialite.NombreDeCouverts = 4;
            restaurant1.Specialite.Plats = new List<string>() { "carrotes", "poulet" };
            Console.WriteLine($"Service : {restaurant1.ExecuterService()}");

            var restaurant2 = new RestaurantGeneric<SpecialiteSoupe>();
            restaurant2.Specialite.NombreDeCouverts = 3;
            restaurant2.Specialite.AvecSoupeOignon = true;
            restaurant2.Specialite.Plats = new List<string>() { "soupe a l'oignon", "fromage" };
            Console.WriteLine($"Service : {restaurant2.ExecuterService()}");
            Console.WriteLine(restaurant2.Specialite.ServirSoupe());

            List<string> maListe1 = new List<string>() { "a", "z", "e", "r", "t", "y" };
            Console.WriteLine(string.Join(", ", 
                maListe1
                .OrderBy(m=>m)
                .ToArray()));

            List<int> maListe2 = new List<int>() { 1, 5, 6, 7, 2 };
            Console.WriteLine(string.Join(", ",
                maListe2
                .OrderBy(m => m)
                .Select(m=>m.ToString())
                .ToArray()));

        }
    }
}
