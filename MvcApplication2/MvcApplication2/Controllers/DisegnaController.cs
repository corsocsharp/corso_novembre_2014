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

        public ActionResult Quadrato(int lato = 10, string carattere = "*")
        {

            ViewBag.Lato = lato;
            ViewBag.Carattere = carattere;

            return View();

        }

    }
}
