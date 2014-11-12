using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class DisegnaController : Controller
    {
        //
        // GET: /Disegna/

        public ActionResult Riga(int lunghezza)
        {

            ViewBag.Lunghezza = lunghezza;

            return View();
        }

    }
}
