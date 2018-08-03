using BankingApp.L1.DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.L1.DataAccess.Facade;
using BankingApp.L2.Business.Facade;
using BankingApp.L1.DataAccess.Implementations;

namespace BankingApp.L2.Business.Implementation
{
    public class CompteBusinessImpl : ICompteBusiness
    {
        public const decimal TAUX = 0.1M;
        private ICompteRepository repo = new ComptesRepositoryImp_EF(); 

        public decimal ConsulterSolde(string Id)
        {
            var resultat = repo.FindById(Id);
            if (resultat != null)
            {

                return resultat.Numero.StartsWith("E") ? resultat.Solde * (1 * TAUX) : resultat.Solde ; 

            }

            return decimal.MinValue;
        }
    }
}
