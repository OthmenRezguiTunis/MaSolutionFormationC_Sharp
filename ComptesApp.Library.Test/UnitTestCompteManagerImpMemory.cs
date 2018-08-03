using System;
using System.Collections.Generic;
using ComptesApp.Library.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ODDO.Clients.Console.Domain;

namespace ComptesApp.Library.Test
{
    [TestClass]
    public class UnitTestCompteManagerImpMemory
    {


        [TestMethod]
        public void FindByIdTest ()
        {
            var underTest = new CompteManagerImpl_Memory();
            var Expected = new Compte { Numero = "C1000", Solde = 1000M, Proprietaire = "Zakareyya" };
            var id = "C1000";



            //ACT

            var Actual = underTest.FindById(id);

            //foreach(var item in Actual)
            //{
            //    Console.WriteLine(item.Proprietaire);
            //}
             
            //ASSERT

            Assert.AreEqual(Expected, Actual);
        }



        [TestMethod]
        public void OuvrirCompteTest()
        {
            //ARRANGE 

            Assert.Fail();
        }

        [TestMethod]
        public void TestFindAll()
        {
            //ARRANGE 

            var underTest = new CompteManagerImpl_Memory();
            var Expected = 3; // NUmber of existing Counts 

            //ACT

            var Actual = underTest.FindAll();

            //foreach(var item in Actual)
            //{
            //    Console.WriteLine(item.Proprietaire);
            //}

            //ASSERT

            Assert.AreEqual(Expected, ((IList<Compte>)Actual).Count);

        }
    }
}
