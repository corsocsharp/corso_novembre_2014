using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcContatti.Models;


namespace MvcContatti.Controllers
{
    public class RubricaController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            DBService db = new DBService();

            List<Contatto> contatti = db.ListContatti();

            return View(contatti);
        }


        public ActionResult New() {
            return View();
        }

    }
}
