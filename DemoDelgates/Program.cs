using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelgates
{
   
   class Program
    {
       
       static void Main(string[] args)
        {


            // since c# 4 , 2006 (Action and Func)
             Action<int , int> del = CalculUtils.Additionner; // subscription
             del += CalculUtils.Multiplier; // another subscription

            // Another subscription using an anonymous delegate C# 2 , 2005

            del +=  (a,b) => { Console.WriteLine($"La Soustraction de {a} et de {b} est égale à {a - b}"); }; // lambda since c# 3 , 2008

            del(11, 22); // Notification
            

        }

     
    }
}
