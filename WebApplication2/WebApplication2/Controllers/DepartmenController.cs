using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DepartmenController : Controller
    {
        
        public ActionResult hello()
        {
            var departmen = new Departmen() { id = 1, ad = "hjjh" } ;

            return View(departmen);
        }
    }
}