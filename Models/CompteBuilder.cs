using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPBuilder.Models
{
    public abstract class CompteBuilder
    {
        protected Compte compte;
        public Compte Compte
        {
            get { return compte; }
        }

        public abstract void BuildNumero();

        public abstract void BuildMontant();
    }
}