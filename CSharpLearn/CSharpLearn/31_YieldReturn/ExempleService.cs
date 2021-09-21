using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._31_YieldReturn
{
    public class ExempleService
    {
        #region Test 1
        private IEnumerator<int> GetInts()
        {
            //https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/keywords/yield
            //La séquence retournée par une méthode d’itérateur peut être consommée à l’aide d’une instruction foreach ou d’une requête LINQ.
            //Chaque itération de la boucle foreach appelle la méthode Iterator. Lorsqu'une instruction yield return est atteinte dans la méthode Iterator,
            //expression est retourné, et l'emplacement dans le code est conservé.
            //L'exécution redémarrera à partir de cet emplacement la prochaine fois que la fonction d'itérateur sera appelée.
            Console.WriteLine("first");
            yield return 1;

            Console.WriteLine("second");
            yield return 2;
        }

        private void Test1()
        {
            IEnumerator<int> intsEnumerator = GetInts();
            Console.WriteLine("...");

            intsEnumerator.MoveNext();
            Console.WriteLine(intsEnumerator.Current);
            Console.WriteLine("...");

            intsEnumerator.MoveNext();
            Console.WriteLine(intsEnumerator.Current);
            Console.WriteLine("...");

        }
        #endregion
        #region Test 2

        private IEnumerable<int> GetListeAvecYield()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Fetching item {i} with yield return");
                yield return i;
            }
        }

        private IEnumerable<int> GetListeSansYield()
        {
            var list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Fetching item {i} without yield return");
                list.Add(i);
            }
            return list;
        }

        private void Test2()
        {
            Console.WriteLine("Processing data without yield return : BEGIN");
            foreach (var item in GetListeSansYield()){
                Console.WriteLine($"Fetched item : {item}");
            }
            Console.WriteLine("Processing data without yield return : END");

            Console.WriteLine("Processing data without with return : BEGIN");
            foreach (var item in GetListeAvecYield())
            {
                Console.WriteLine($"Fetched item : {item}");
            }
            Console.WriteLine("Processing data without with return : END");

        }
        #endregion

        public void Execute()
        {
            Console.WriteLine("##### Test 1 #####");
            Test1();

            Console.WriteLine("##### Test 2 #####");
            Test2();
        }
    }
}
