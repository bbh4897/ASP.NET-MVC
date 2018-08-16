using PersonalUI.Models.EntitityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PersonalUI.Controllers
{
    public class DepartmenController : Controller
    {

        PersonelDbEntities ent = new PersonelDbEntities();
        // GET: Departmen
        public ActionResult Index()
        {
            var model = ent.Departmen.ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Ekle()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Departmen departmen)
        {
            ent.Departmen.Add(departmen);
            ent.SaveChanges();

            return RedirectToAction("Index","Departmen");
        }

    }
}