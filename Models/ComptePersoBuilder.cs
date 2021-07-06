using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPBuilder.Models
{
    public class ComptePersoBuilder : CompteBuilder
    {
        public ComptePersoBuilder()
        {
            compte = new Compte("PERSO");
        }

        public override void BuildNumero()
        {
            compte.Numero = "PERSO" + Guid.NewGuid();
        }

        public override void BuildMontant()
        {
            compte.Montant = 100;
        }
    }
}