using ComptesApp.Library.Facade;
using ODDO.Clients.Console.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesApp.Library.Implementations
{
    public class CompteManagerImpl_Memory : ICompteManager
    {

        private IList<Compte> data =
            new List<Compte>
            {
                new Compte { Numero = "C1000" , Solde = 1000M , Proprietaire = "Zakareyya"},
                new Compte { Numero = "C2000" , Solde = 2000M , Proprietaire = "Othmen"},
                new Compte { Numero = "C3000" , Solde = 3000M , Proprietaire = "khalil"}

            };
        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compte> FindAll()
        {
            return data;
        }

        public Compte FindById(string Id)
        {
            return data.FirstOrDefault(x => x.Numero.Equals(Id));
        }

        public void OuvrirCompte(Compte e)
        {
            throw new NotImplementedException();
        }

        public void UpdateCompte(Compte e)
        {
            throw new NotImplementedException();
        }
    }
}
