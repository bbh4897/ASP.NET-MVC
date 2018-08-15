using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Route("Hakkımızda")]
        public ActionResult About()
        {
            return View();
        }
        [Route("Ürünler")]
        public ActionResult Product()
        {
            return View();
        }
        [Route("İletişim")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}