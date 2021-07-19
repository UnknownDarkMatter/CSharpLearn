using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._04_TryCatch
{
    class ExempleService
    {
        public void Execute()
        {
            Console.WriteLine("Before try catch 1/2");
            try
            {
                decimal zero = 0;
                var foo = 1 / zero;
               
            }
            catch(Exception ex)
            {
                Console.WriteLine($"catch exception {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Le finally est toujours appellé");
            }


            Console.WriteLine("Before try catch : 2/2");
            try
            {
                //do nothing
            }
            catch (Exception ex)
            {
                Console.WriteLine($"catch exception {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Le finally est toujours appellé");
            }

        }
    }
}
