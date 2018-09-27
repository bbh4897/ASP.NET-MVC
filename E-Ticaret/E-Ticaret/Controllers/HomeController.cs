using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret.Controllers
{
    public class HomeController : Controller
    {
        // Navbar Seçenekler
        public ActionResult Index()
        {
            return View();
        }
        [Route("Hakkımızda")]
        public ActionResult Hakkimizda()
        {
            return View();
        }
        [Route("Ürünler")]
        public ActionResult Urunler()
        {
            return View();
        }
        [Route("İletişim")]
        public ActionResult Iletisim()
        {
            return View();
        }

        [Route("GirişYap")]
        public ActionResult GirisYap()
        {
            return View();
        }



        // Kategoriler
        [Route("Moda")]
        public ActionResult Moda()
        {
            return View();
        }

        [Route("Teknoloji")]
        public ActionResult Teknoloji()
        {
            return View();
        }

        [Route("Kitap-DVD")]
        public ActionResult KitapDV()
        {
            return View();
        }


        // Giriş Yap _ Kayıt Ol
        [Route("GirişSeçim")]
        public ActionResult GirisSecim()
        {

            return View();
        }



    }
}