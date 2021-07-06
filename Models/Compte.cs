using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPBuilder.Models
{
    public class Compte
    {
        public Compte(string type)
        {
            Type = type;
        }

        public string Type { get; set; }
        public string Numero { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public double Montant { get; set; }
        public DateTime DateCreation { get; set; }
    }
}