using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._31_YieldReturn
{
    public class ExempleService
    {
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

        public void Execute()
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
    }
}
