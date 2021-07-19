using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._04_StructRefOut
{
    public class ExempleService
    {
        public void Execute()
        {
            //String
            var value = "nonmodifié";
            EssaiModificationStringSansRef(value);
            Console.WriteLine($"EssaiModificationStringSansRef {value}");

            EssaiModificationStringAvecRef(ref value);
            Console.WriteLine($"EssaiModificationStringAvecRef {value}");

            var monnaie1 = new Monnaie();
            monnaie1.Valeur = 200;
            EssaiModificationMonnaieSansRef(monnaie1);
            Console.WriteLine($"EssaiModificationMonnaieSansRef : {monnaie1.Valeur}");

            EssaiModificationMonnaieAvecRef(ref monnaie1);
            Console.WriteLine($"EssaiModificationMonnaieAvecRef : {monnaie1.Valeur}");


            var datetime = DateTime.Now;

            EssaieModificationDateTimeSansRef(datetime);
            Console.WriteLine($"EssaieModificationDateTimeSansRef : {datetime}");

            EssaieModificationDateTimeAvecRef(ref datetime);
            Console.WriteLine($"EssaieModificationDateTimeAvecRef : {datetime}");

            var employe = new Employe();
            employe.Salaire = 5000;
            EssaiModificationEmploye(employe);
            Console.WriteLine($"EssaiModificationEmploye : {employe.Salaire}");

            datetime = DateTime.MinValue;
            GetDate(out datetime);
            Console.WriteLine($"GetDate : {datetime}");
        }
        public void EssaiModificationStringSansRef(string value)
        {
            value = "modified";
        }
        public void EssaiModificationStringAvecRef(ref string value)
        {
            value = "modified";
        }

        public void EssaiModificationMonnaieSansRef(Monnaie monnaie)
        {
            monnaie.Valeur = -1;
        }
        public void EssaiModificationMonnaieAvecRef(ref Monnaie monnaie)
        {
            monnaie.Valeur = -1;
        }
        public void EssaiModificationEmploye(Employe employe)
        {
            employe.Salaire = -1;
        }
        public void EssaieModificationDateTimeSansRef(DateTime dateTime)
        {
            dateTime = dateTime.AddYears(-1000);
        }
        public void EssaieModificationDateTimeAvecRef(ref DateTime dateTime)
        {
            dateTime = dateTime.AddYears(-2000);
        }

        public void GetDate(out DateTime dateTime)
        {
            dateTime = DateTime.Now;
        }
    }
}
