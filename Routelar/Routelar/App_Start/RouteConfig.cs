using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routelar
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "sade",
                url: "",
                defaults: new { controller = "personeldeneme", action = "sade" }
            );

            // routes.MapRoute(
            //    name: "Liste",
            //    url: "personel/liste/{olcut}/{sayfa}",
            //    defaults: new { controller = "PersonelDeneme", action = "liste"}
            //);


        }
    }
}
