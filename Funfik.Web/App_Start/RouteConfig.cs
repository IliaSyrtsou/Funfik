﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Funfik.Web.Areas.Administration;

namespace Funfik.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Administration",
            //    url: "Administration/{controller}/{action}/{id}",
            //    defaults: new {action = "Index", id = UrlParameter.Optional});

            //routes.MapRoute(
            //    name: "Default",
            //    url: "Default/{controller}/{action}/{id}",
            //    defaults: new { action = "Index", id = UrlParameter.Optional });
        }
    }
}