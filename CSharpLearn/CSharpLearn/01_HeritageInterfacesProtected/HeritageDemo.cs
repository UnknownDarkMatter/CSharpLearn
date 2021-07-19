using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._01_HeritageInterfacesProtected
{
    public class HeritageDemo
    {
        public void Execute()
        {
            Chien chien = new Chien("Max");
            Console.WriteLine(chien.Parler());
            chien.Mordre();

            Chat chat = new Chat("mon petitchat");
            string message = chat.Parler();
            Console.WriteLine(message);

            Chiot monChiot = new Chiot("toto", "cuir");
            Console.WriteLine(monChiot.Parler());
            Console.WriteLine($"Le jouet du chiot est {monChiot.Jouet}");
            monChiot.Jouet = "os";
            Console.WriteLine($"Le jouet du chiot est {monChiot.Jouet}");

            Console.WriteLine($"Le collier du chiot est en {monChiot.Collier}");
            // monChiot.Collier = "Tissu";
            Console.WriteLine($"Le collier du chiot est en {monChiot.Collier}");

            Console.WriteLine($"moi c'est {monChiot.Nom} et mon collier est en {monChiot.Collier}");

        }
    }
}
