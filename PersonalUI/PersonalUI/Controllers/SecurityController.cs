using PersonalUI.Models.EntitityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PersonalUI.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        PersonelDbEntities db = new PersonelDbEntities();
        // GET: Security
       
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            var kullanicidb = db.Kullanici.FirstOrDefault(x => x.Ad == kullanici.Ad && x.Sifre==kullanici.Sifre);
            if (kullanicidb != null)
            {
                FormsAuthentication.SetAuthCookie(kullanicidb.Ad, false);
                return RedirectToAction("Index", "Departmen");
            }
            else
            {
                ViewBag.Message="Geçersiz Kullanıcı Adı veya Şifre";
                return View();
            }
            
        }


        public ActionResult LoginOut()
        {
            FormsAuthentication.SignOut();
            return View("Login");
        }

    }
}