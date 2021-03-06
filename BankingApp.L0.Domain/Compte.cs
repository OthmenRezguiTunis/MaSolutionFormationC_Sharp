﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L0.Domain
{
  public class Compte
    {
      [Key]  public string Numero { get; set; } //Auto Imp Property (C#3)
        public string Proprietaire { get; set; }
        public decimal Solde { get; set; }


        public void Debiter(decimal montant)
        { 
            Solde -= montant;
        }


        public void Crediter (decimal montant)
        {

            Solde += montant;

        }

        public override string ToString()
        {
            return "Compte  : [" + Numero + " - " + Proprietaire + "-" + Solde +" ]" ;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            Compte converti = obj as Compte;
            return  Numero.Equals(converti.Numero)
                && Solde.Equals(converti.Solde)
                && Proprietaire.Equals(converti.Proprietaire);    
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return Numero.GetHashCode();
        }

    }
    

   
}
