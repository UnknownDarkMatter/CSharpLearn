using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._08_continue_break
{
    class ExempleService
    {
        internal void Execute()
        {
            var maListe = new List<Tuple<string, DateTime>>()
            {
                new Tuple<string, DateTime>("année de naissance toto", new DateTime(1989,08,5)),
                new Tuple<string, DateTime>("année de naissance Max", new DateTime(2002,07,03)),
            };

            foreach (var tuple in maListe)
            {
                Console.WriteLine($"Premier foreach : {tuple.Item1} est: {tuple.Item2.ToString("yyyy-MM-dd")}");
            }
            for (int i = 0; i < maListe.Count;i++)
            {
                var tuple = maListe[i];
                Console.WriteLine($"Second forEach : {tuple.Item1} est: {tuple.Item2.ToString("yyyy-MM-dd")}");
            }
        }
    }
}
