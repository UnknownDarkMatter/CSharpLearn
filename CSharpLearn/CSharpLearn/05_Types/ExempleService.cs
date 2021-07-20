using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._05_Types
{
    class ExempleService
    {
        internal void Execute()
        {
            //cast
            int a = 3;
            long b = 6;
            a = (int)b;

            DateTime date = DateTime.Now.AddDays(-2000);
            Console.WriteLine($" la date est {date}");

            date.AddDays(20);
            Console.WriteLine($" la date est {date}");

            var date1 = DateTime.Now;
            Console.WriteLine($" la date est {date1}");

            TimeSpan timeSpan = date1.Subtract(date);
            Console.WriteLine($" nombre jours :  {timeSpan.TotalHours}");
            Console.WriteLine($" nombre jours :  {timeSpan.TotalDays}");

            decimal monDecimal = 5.2M;
            var maVar = monDecimal.ToString();
            Console.WriteLine($" ma var decimal {maVar}");
            Console.WriteLine($" decimal {monDecimal.ToString("0.000")}");
            Console.WriteLine($" decimal {monDecimal.ToString("0.###")}");
            monDecimal = 5.123456M;
            Console.WriteLine($" decimal {monDecimal.ToString("0.###")}");
            Console.WriteLine($" decimal {monDecimal.ToString()}");
            Console.WriteLine($" decimal separé par un point {monDecimal.ToString(new System.Globalization.CultureInfo("en-GB"))}");

            string value = "3.4";
            monDecimal = Convert.ToDecimal(value, new System.Globalization.CultureInfo("en-GB"));
            Console.WriteLine($" en-GB string convertit {monDecimal}");

            value = "3,4";
            monDecimal = Convert.ToDecimal(value);
            Console.WriteLine($" string convertit {monDecimal}");

            value = "3,8";
            monDecimal = Convert.ToDecimal(value, new System.Globalization.CultureInfo("fr-FR"));
            Console.WriteLine($" fr-FR string convertit {monDecimal}");

            
        }
    }
}
