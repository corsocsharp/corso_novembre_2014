using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class DisegnaController : Controller
    {
        public ActionResult Index()
        {
            return View("righe");
        }

        public ActionResult Righe(int lunghezza = 10)
        {

            ViewBag.Lunghezza = lunghezza;

            return View();

        }

        public ActionResult Quadrato(string azione, int lato = 10,
                                                string carattere = "*")
        {

            if (String.IsNullOrEmpty(azione)) {
                azione = "Quadrato";
            }

            ViewBag.Lato = lato;
            ViewBag.Carattere = carattere;
            ViewBag.Azione = azione;

            return View();

        }

        public ActionResult Rettangolo(int latoA = 10, int latoB = 10, 
                        string carattere = "*")
        {

            ViewBag.LatoA = latoA;
            ViewBag.LatoB = latoB;
            ViewBag.Carattere = carattere;

            return View();

        }
    }
}
