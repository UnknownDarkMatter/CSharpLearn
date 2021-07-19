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
            Chien chien = new Chien();
            Console.WriteLine(chien.Parler());
            chien.Mordre();
            Chat chat = new Chat();
            string message = chat.Parler();
            Console.WriteLine(message);

        }
    }
}
