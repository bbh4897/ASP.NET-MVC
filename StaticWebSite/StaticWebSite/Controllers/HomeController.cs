using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebSite.Controllers
{
    public class HomeController : Controller
    {
        
        
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
        public ActionResult Products()
        {
            return View();
        }

        [Route("Mağaza")]
        public ActionResult Store()
        {
            return View();
        }
    }
}