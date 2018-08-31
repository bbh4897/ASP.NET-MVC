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
            return View("Ekle", new Departmen());
        }

        //[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Departmen departmen)
        {
            if (!ModelState.IsValid)
            {
                return View("Ekle");
            }
            if (departmen.Id == 0)
            {
                ent.Departmen.Add(departmen);
            }
            else
            {
                var guncelId = ent.Departmen.Find(departmen.Id);
                if (guncelId == null)
                {
                   return  HttpNotFound();
                }
                guncelId.Ad = departmen.Ad;

            }
            ent.SaveChanges();
            return RedirectToAction("Index","Departmen");
        }

        public ActionResult Guncelle(int id)
        {
            var model = ent.Departmen.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("Ekle", model);
        }

        public ActionResult sil(int id)
        {
            var silId = ent.Departmen.Find(id);
            if(silId == null)
            {
                return HttpNotFound(); 
            }
            ent.Departmen.Remove(silId);
            ent.SaveChanges();
            return RedirectToAction("Index", "Departmen");

        }

    }
}