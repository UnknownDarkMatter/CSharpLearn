using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._05_DisposeUsing
{
    public class MonDisposableComponent : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose a été appellé ");
        }

        public MonDisposableComponent()
        {
            Console.WriteLine("Le constructeur a été appellé");
        }

        ~MonDisposableComponent()
        {
            Console.WriteLine("Le desctucteur a été appellé");
        }
        public void Parler()
        {

            Console.WriteLine("Say my name !!!");
        }

        public void Test()
        {
            throw new Exception(" this is a test");
        }
    }
}
