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
            Console.WriteLine("Dispos a été appellé ");
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
