using PersonalUI.Models.EntitityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalUI.Controllers
{
    public class PersonalController : Controller
    {
        PersonelDbEntities ent = new PersonelDbEntities();
        // GET: Departmen
        public ActionResult Index()
        {
            var model = ent.Personel.ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydet(Personel personel)
        {
            if (personel.Id == 0)
            {
                ent.Personel.Add(personel);
            }
            else
            {
                var guncelId = ent.Personel.Find(personel.Id);
                if (guncelId == null)
                {
                    return HttpNotFound();
                }
                
                guncelId.DepartmenId = personel.DepartmenId;
                guncelId.Ad = personel.Ad;
                guncelId.Soyad = personel.Soyad;
                guncelId.Yas = personel.Yas;
                guncelId.Maas = personel.Maas;
                guncelId.DogumTarihi = personel.DogumTarihi;
                guncelId.Cinsiyet = personel.Cinsiyet;
                guncelId.Evlimi = personel.Evlimi;

            }
            ent.SaveChanges();
            return RedirectToAction("Index", "Personal");
        }

        public ActionResult Guncelle(int id)
        {
            var model = ent.Personel.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("Ekle", model);
        }

        public ActionResult sil(int id)
        {
            var silId = ent.Personel.Find(id);
            if (silId == null)
            {
                return HttpNotFound();
            }
            ent.Personel.Remove(silId);
            ent.SaveChanges();
            return RedirectToAction("Index", "Personal");

        }

    }
}