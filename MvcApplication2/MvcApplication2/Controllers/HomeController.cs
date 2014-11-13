using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Title = "Titolo in action";
            return View();
        }

        public string FaiCose() {
            return "ciao";
        }

        public ActionResult Somma(int val1 = 0, int val2 = 0) {

            int somma = val1 + val2;

            ViewBag.Valore1 = val1;
            ViewBag.Valore2 = val2;
            ViewBag.Risultato = somma;

            return View();

        }

    }
}
