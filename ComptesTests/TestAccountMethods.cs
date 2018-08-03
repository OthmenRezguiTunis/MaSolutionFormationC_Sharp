using System;
using BankingApp.L0.Domain;
using BankingApp.L1.DataAccess.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComptesTests
{
    [TestClass]
    public class TestAccountMethods
    { 
        [TestMethod]
        public void TestOuvrirCompteMethod()
        {
            var c = new Compte() { Numero = "E3000", Proprietaire = "MohamedAmine", Solde = 1000M };
            var UnderTest = new ComptesRepositoryImp_EF();

            UnderTest.OuvrirCompte(c);

        }

        [TestMethod]
        public void TestFindById_Nominal()
        {
            var Id = "C2000";
           
            var UnderTest = new ComptesRepositoryImp_EF();
            var Excpected = new Compte() { Numero = "C2000", Proprietaire = "MohamedAmine", Solde = 1000M };

            var Actual =  UnderTest.FindById(Id);
            Assert.AreEqual(Excpected, Actual);

        }


        [TestMethod]
        public void TestFindById_Degrade()
        {
            var Id = "Z100";

            var UnderTest = new ComptesRepositoryImp_EF();
           

            var Actual = UnderTest.FindById(Id);
            Assert.IsNull(Actual);

        }
    }
}
