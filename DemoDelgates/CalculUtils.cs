using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelgates
{
  public  class CalculUtils
    {

        public static void Additionner(int a, int b)
        {
            Console.WriteLine($"La somme de {a} et de {b} est égale à {a + b}");


        }

        public static void Multiplier(int a, int b)
        {
            Console.WriteLine($"Le produit de {a} et de {b} est égale à {a * b}");

        }
    }
}
