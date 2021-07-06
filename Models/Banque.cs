using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPBuilder.Models
{
    public class Banque
    {
        public void Construct(CompteBuilder builder)
        {
            builder.BuildNumero();
            builder.BuildDateCreation();
        }
    }
}