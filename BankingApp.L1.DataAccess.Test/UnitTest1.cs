using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingApp.L0.Domain;
namespace BankingApp.L1.DataAccess.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Compte() { Numero = "C1000" , Proprietaire = "MohamedAmine" , Solde = "1000M"};
            var UnitTest = new BankingApp.L1.DataAccess.Implementations.ComptesRepositoryImp_EF();

            UnitTest.OuvrirCompte(c);

            //


        }
    }
}
