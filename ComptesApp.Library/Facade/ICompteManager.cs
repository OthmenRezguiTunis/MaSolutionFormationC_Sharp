using ODDO.Clients.Console.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesApp.Library.Facade
{
   public interface ICompteManager
    {
        // CRUD Contract 

        void OuvrirCompte(Compte e); // c 
        Compte FindById(string Id); //r
        IEnumerable<Compte> FindAll(); //r
        void UpdateCompte(Compte e); //u
        void Delete(string Id); //d

    }
}
