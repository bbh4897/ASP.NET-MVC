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
        [Route("İzlediklerim")]
        public ActionResult İzlediklerim()
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
        [Route("Dini")]
        public ActionResult Dini()
        {
            return View();
        }

        [Route("Mesleki")]
        public ActionResult Mesleki()
        {
            return View();
        }

        [Route("KişiselGelişim")]
        public ActionResult KisiselGelisim()
        {
            return View();
        }


        // Giriş Yap _ Kayıt Ol
        [Route("GirişSeçim")]
        public ActionResult GirisSecim()
        {

            return View();
        }


        // Random
        [Route("DiniVideoİzle")]
        public ActionResult DiniVideo()
        {
            string[] lines = System.IO.File.ReadAllLines("D:\\PROJELER\\ASP.NET\\E-Ticaret\\E-Ticaret\\Files\\dini.txt");
            Random rand = new Random();
            return Redirect(lines[rand.Next(lines.Length)]);
        }

        [Route("YazilimVideoİzle")]
        public ActionResult YazilimVideo()
        {
            string[] lines = System.IO.File.ReadAllLines("D:\\PROJELER\\ASP.NET\\E-Ticaret\\E-Ticaret\\Files\\yazilim.txt");
            Random rand = new Random();
            return Redirect(lines[rand.Next(lines.Length)]);
        }

        [Route("KişiselGelişimVideoİzle")]
        public ActionResult KisiselGelisimVideo()
        {
            string[] lines = System.IO.File.ReadAllLines("D:\\PROJELER\\ASP.NET\\E-Ticaret\\E-Ticaret\\Files\\kisisel.txt");
            Random rand = new Random();
            return Redirect(lines[rand.Next(lines.Length)]);
        }



    }
}