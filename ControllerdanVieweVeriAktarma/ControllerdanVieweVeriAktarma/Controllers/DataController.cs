using ControllerdanVieweVeriAktarma.DepartmenPersonelViewModel;
using ControllerdanVieweVeriAktarma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ControllerdanVieweVeriAktarma.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult dataAl(int id)
        {
            var departmen = new Models.Departmen() { id = id, ad = "burcu" };
            ViewData["departmen"] = departmen;
            ViewBag.Burcu = "burcu bağ";
            return View();
        }


        public ActionResult detay(int id)
        {
            ViewData["detayId"] = id;
            return View();
        }

        public ActionResult departmenPersonelDetay(int id)
        {
            var departmen = new Departmen() { id = id, ad = "departman1" };
            var personel = new List<Personel>()
            {
                new Personel(){ad = "Personel1"},
                new Personel(){ad = "Personel2"},
                new Personel(){ad = "Personel3"}
            };

            var model = new DepartmenPersonel()
            {
                Departmen = departmen,
                Personel = personel
            };
            return View(model);
        }
    }
}