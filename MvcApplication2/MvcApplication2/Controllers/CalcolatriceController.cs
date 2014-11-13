using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class CalcolatriceController : Controller
    {

        public ActionResult Index()
        {
            return RedirectToAction("Calcola");
        }

        public ActionResult Calcola(string operazione,int val1 = 0, int val2 = 0)
        {
            double risultato = 0;
            if (operazione == "+") {
                risultato = val1 + val2;
            }
            if (operazione == "-")
            {
                risultato = val1 - val2;
            }
            if (operazione == "*")
            {
                risultato = val1 * val2;
            }
            if (operazione == "/")
            {
                risultato = val1 / (double) val2;
            }

            ViewBag.Valore1 = val1;
            ViewBag.Valore2 = val2;
            ViewBag.Operazione = operazione;
            ViewBag.Risultato = risultato;

            return View();
        }

    }
}
