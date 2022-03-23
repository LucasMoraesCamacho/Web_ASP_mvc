using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_ASP_mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Secundaria",
                url: "{controller}/{action}/{id}/{name}",
                defaults: new 
                { 
                    controller = "Propriedades",
                    action = "Index"
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new 
                { 
                    controller = "Propriedades",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
