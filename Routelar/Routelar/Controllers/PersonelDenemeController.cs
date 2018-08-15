using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routelar.Controllers
{
    public class PersonelDenemeController : Controller
    {
        [Route("personel/liste/{olcut}/{sayfa}")]
        public ActionResult liste(String olcut, int sayfa)
        {
            return Content(olcut + "---"+ sayfa); 
        }

        public ActionResult sade()
        {
            return Content("Sade URL");
        }
    }
} 