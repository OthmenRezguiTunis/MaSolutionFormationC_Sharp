using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelgates
{
    class DemoLinq
    {

        static void Main(string[] args )
        {
            IEnumerable<string> Participants = new List<string>() {
           "Mohamed Amine" , "Khalil" , "Abdessalem" ,  "Othmen" , "oussema" , "Ahmed"};


           var list_extension_style =  Participants.Where(x => x.StartsWith("A")).Select(x=> new { id = 5 , Nom = x });
            var list_querystyle_style = from p in Participants
                                        where p.StartsWith("O")
                                        select new { Nom = p , Job = "developpeur"};
        }
    }
}
