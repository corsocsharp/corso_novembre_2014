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

        public ActionResult Save(string nome, string cognome) {
            
            Contatto c = new Contatto() { 
                Nome = nome,
                Cognome = cognome
            };

            DBService db = new DBService();
            db.AddContatto(c);

            return RedirectToAction("List");
        }

        public ActionResult View(string id) {

            DBService db = new DBService();
            Contatto c = db.GetContatto(id);

            return View(c);

        }

    }
}
