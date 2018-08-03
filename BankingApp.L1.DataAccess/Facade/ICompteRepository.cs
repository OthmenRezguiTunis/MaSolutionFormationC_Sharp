using BankingApp.L0.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.DataAccess.Facade
{
   public  interface ICompteRepository
    {

        // CRUD Contract 

        void OuvrirCompte(Compte e); // c 
        Compte FindById(string Id); //r
        IEnumerable<Compte> FindAll(); //r
        void UpdateCompte(Compte e); //u
        void Delete(string Id); //d

    }
}
