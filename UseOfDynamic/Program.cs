using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
             static void Main(string[] args)
            {
            //Overcoming Compile time problem related with var
            //eg var "Hello World! was the first Program Written By Sir Dennis Ritchie !";
            //i=false;
            dynamic dynamicVariable = 200;
                Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

               dynamicVariable = "Hello World! was the first Program Written By Sir Dennis Ritchie !";
            
                Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

                dynamicVariable = false;
                Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

                dynamicVariable = DateTime.Now;
                Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());
            }
        }
    }
}
