using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._09_LinqPipeline
{
    class ExempleService
    {
        internal void Execute()
        {
            var maListe = new List<Tuple<string, int>>()
            {
                new Tuple<string, int>("Riz", 4),
                new Tuple<string, int>("Harissa", 5),
                new Tuple<string, int>("poisson", 12),
                new Tuple<string, int>("pizza", 2),
                new Tuple<string, int>("fromage", 20),
                new Tuple<string, int>("Poulet", 3),
            };

            Console.WriteLine("tri croissant");
            Console.WriteLine(string.Join(Environment.NewLine,
                maListe
                .Where(m => m.Item2 > 10)
                .OrderBy(m => m.Item2) //expression lambda
                .Select(m => $"Menu : {m.Item1}, nb : {m.Item2}")));

            Console.WriteLine("tri décroissant");
            Console.WriteLine(string.Join(Environment.NewLine,
                maListe
                .Where(m => m.Item2 > 10)
                .OrderByDescending(m => m.Item2) //expression lambda
                .Select(m => $"Menu : {m.Item1}, nb : {m.Item2}")));

            Console.WriteLine("Somme : " +
                maListe
                .Where(m => m.Item2 <= 10)
                .Sum(m => m.Item2));

            Console.WriteLine("Moyenne : " +
                maListe
                .Average(m => m.Item2));


            Console.WriteLine("groupe par nombre avec lambda expression"); 
            maListe = new List<Tuple<string, int>>()
            {
                new Tuple<string, int>("Riz", 2),
                new Tuple<string, int>("Harissa", 2),
                new Tuple<string, int>("poisson", 2),
                new Tuple<string, int>("pizza", 5),
                new Tuple<string, int>("fromage", 5),
                new Tuple<string, int>("Poulet", 6),
            };
            Console.WriteLine(string.Join(Environment.NewLine,
                maListe
                .GroupBy(   m => m.Item2, 
                            m => m.Item1,
                            (clé, grouped) => clé + "- " + string.Join(", ", grouped))));


            Console.WriteLine("groupe par nombre avec LinQ");
            var query = from menu in maListe
                        group menu.Item1 by menu.Item2 into menuGrouped
                        select string.Join(", ", (menuGrouped.Select(m => menuGrouped.Key.ToString() + " - " + m)));
            Console.WriteLine(string.Join(Environment.NewLine, query));
             
            //usage le plus courant
            maListe = new List<Tuple<string, int>>()
            {
                new Tuple<string, int>("Riz", 2),
                new Tuple<string, int>("Harissa", 2),
                new Tuple<string, int>("poisson", 2),
                new Tuple<string, int>("pizza", 4),
                new Tuple<string, int>("fromage", 5),
                new Tuple<string, int>("Poulet", 6),
            };

            var specialite = maListe
                .OrderByDescending(m => m.Item2)
                .Where(m => m.Item2 < 6)
                .FirstOrDefault()
                .Item1;
            Console.WriteLine($"Spécialité : {specialite}");
        }
    }
}
