using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class DefaultController : Controller
    {
       public ActionResult metod1()
        {
            var df = new Models.Model1() { id = 1, ad = "burcu basfdsafdağ" };
            return View(df);
        }

        public ActionResult sade()
        {
            return Content("sade");
        }

        public ActionResult liste(String olcut, int sayfa)
        {
            return Content(olcut + "---" + sayfa);
        }

    }
}