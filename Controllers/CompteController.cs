using DPBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DPBuilder.Controllers
{
    public class CompteController : Controller
    {
        public CompteBuilder compteBuilder { get; set; }

        public ActionResult Etape1()
        {
            Banque banque = new Banque();
            compteBuilder = new ComptePersoBuilder();
            banque.Construct(compteBuilder);

            //compteBuilder.BuildNumero();

            return View();
        }

        public ActionResult Etape2()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Etape3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}