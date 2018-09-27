using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DosyaOkuma.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public string ff()
        {
            string[] lines = System.IO.File.ReadAllLines("D:\\test.txt");
            Random rand = new Random();
            return lines[rand.Next(lines.Length)];

        }
    }
}