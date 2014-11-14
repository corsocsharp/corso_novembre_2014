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

        DBService _db;

        public RubricaController() {
            _db = new DBService();
        }


        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            List<Contatto> contatti = _db.ListContatti();

            return View(contatti);
        }


        public ActionResult New() {
            return View();
        }

        public ActionResult Save(string id, string nome, string cognome) {
            
            Contatto c = new Contatto() { 
                Id = id,
                Nome = nome,
                Cognome = cognome
            };

            if (String.IsNullOrEmpty(id))
            {
                _db.AddContatto(c);

                return RedirectToAction("List");
            }else {
                _db.UpdateContatto(c);

                return Redirect("~/Rubrica/View/" + id);
            }
        }

        public ActionResult View(string id) {

            Contatto c = _db.GetContatto(id);

            return View(c);

        }

        public ActionResult Edit(string id)
        {
            Contatto c = _db.GetContatto(id);

            return View(c);
        }

        public ActionResult Delete(string id) {
            _db.DeleteContatto(id);

            return RedirectToAction("List");
        }

    }
}
