using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MusicPortfolioApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "latest",
                url: "routes/latest",
                defaults: new { controller = "Routes", action = "Latest" }
            );

            routes.MapRoute(
                name: "music",
                url: "routes/music",
                defaults: new { controller = "Routes", action = "Music" }
            );

            routes.MapRoute(
                name: "shop",
                url: "routes/shop",
                defaults: new { controller = "Routes", action = "Shop" }
            );

            routes.MapRoute(
                name: "contact",
                url: "routes/contact",
                defaults: new { controller = "Routes", action = "Contact" }
            );

            routes.MapRoute(
                name: "about",
                url: "routes/about",
                defaults: new { controller = "Routes", action = "About" }
            );

            routes.MapRoute(
                name: "login",
                url: "Account/Login",
                defaults: new { controller = "Account", action = "Login" }
            );

            routes.MapRoute(
                name: "register",
                url: "Account/Register",
                defaults: new { controller = "Account", action = "Register" }
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{*url}",
            //    defaults: new { controller = "Home", action = "Index" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
