using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPBuilder.Models
{
    public class CompteProBuilder : CompteBuilder
    {
        public CompteProBuilder()
        {
            compte = new Compte("PRO");
        }

        public override void BuildNumero()
        {
            compte.Numero = "PRO" + Guid.NewGuid();
        }

        public override void BuildMontant()
        {
            compte.Montant = 1000;
        }
    }
}