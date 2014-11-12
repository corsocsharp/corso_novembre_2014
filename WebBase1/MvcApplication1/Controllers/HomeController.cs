using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Prova()
        {
            return View();
        }



        public string Ora()
        {
            return "Ora: " + DateTime.Now;
        }

        public int Somma(int val1 = 0 , int val2 = 0) {

            return val1 + val2;
        }

    }
}
