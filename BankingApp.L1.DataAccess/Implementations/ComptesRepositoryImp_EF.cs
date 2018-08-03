using BankingApp.L0.Domain;
using BankingApp.L1.DataAccess.Facade;
using BankingApp.L1.DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.DataAccess.Implementations
{
    public class ComptesRepositoryImp_EF : ICompteRepository
    {
        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compte> FindAll()
        {
            using (var ctxt = new BanqueContext ())
            {
                return ctxt.Comptes.ToList();
            }

        }

        public Compte FindById(string Id)
        {
            using (var ctxt = new BanqueContext())
            {
                return ctxt.Comptes.FirstOrDefault(x=>x.Numero.Equals(Id));
            }
        }

        public void OuvrirCompte(Compte e)
        {
            using (var ctxt = new BanqueContext())
            {
                ctxt.Comptes.Add(e);
                ctxt.SaveChanges();
            }
        }

        public void UpdateCompte(Compte e)
        {
            throw new NotImplementedException();
        }
    }
}
