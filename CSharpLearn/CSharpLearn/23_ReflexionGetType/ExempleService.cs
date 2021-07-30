using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._23_ReflexionGetType
{
    public class ExempleService
    {
        internal void Execute()
        {
            int toto = 2;
            int titi = 3;

            //Charger l'assembly et les types
            Assembly testAssembly = Assembly.GetExecutingAssembly();
            Type inputType = testAssembly.GetType("CSharpLearn._23_ReflexionGetType.Input");
            Type calcType = testAssembly.GetType("CSharpLearn._23_ReflexionGetType.Calculette");

            //initialiser deux variables toto et titi
            object inputInstance_toto = Activator.CreateInstance(inputType);
            object inputInstance_titi = Activator.CreateInstance(inputType);
            PropertyInfo valuePropertyInfo = inputType.GetProperty("Value");
            valuePropertyInfo.SetValue(inputInstance_toto, toto, null);
            valuePropertyInfo.SetValue(inputInstance_titi, titi, null);

            //faire la somme
            MethodInfo methodSommeInfo = calcType.GetMethod("Somme");
            ParameterInfo[] parameters = methodSommeInfo.GetParameters();
            object calcInstance = Activator.CreateInstance(calcType, null);

            object[] parametersArray = new object[] { inputInstance_toto, inputInstance_titi };
            object result = methodSommeInfo.Invoke(calcInstance, parametersArray);
            Console.WriteLine($"La somme de {toto} et de {titi} est {result}");
        }
    }
}
