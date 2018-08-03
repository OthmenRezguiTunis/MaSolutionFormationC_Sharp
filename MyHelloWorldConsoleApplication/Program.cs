using ODDO.Clients.Console.Domain;
using System;

namespace ODDO.Clients.Console
{
    class Program
    {
        static void Main(string[] args)
        {     
          
            System.Console.WriteLine("Bienvenue dans C#");
            var Compte = new Compte {Solde =1500 ,
                Numero  = "C1000" , 
                Proprietaire = "Othmen" }; //object initialiser 

            System.Console.WriteLine(Compte);
           
        }
    }
}
