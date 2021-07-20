using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._08_Switch
{
    class ExempleService
    {
        internal void Execute()
        {
            var maListe = new List<int>()
            {
                1, 9, 5, 25, 99
            };
            var countInferieur10 = 0;
            var countSuperieur10 = 0;

            foreach(var i in maListe)
            {
                switch (i)
                {
                    case 1:
                        {
                            countInferieur10++;
                            break;
                        }
                    case 9:
                        {
                            countInferieur10++;
                            break;
                        }
                    case 5:
                        {
                            countInferieur10++;
                            break;
                       }
                    case 25:
                    case 95:
                    case 96:
                    case 97:
                    case 98:
                    case 99:
                        {
                            countSuperieur10++;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }

            Console.WriteLine($"countInferieur10 est {countInferieur10}");
            Console.WriteLine($"countSuperieur10 est {countSuperieur10}");

        }
    }
}
