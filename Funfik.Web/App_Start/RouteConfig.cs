using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Funfik.Web.Areas.Administration;
using Funfik.Web.Areas.Default;

namespace Funfik.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var adminArea = new AdministrationAreaRegistration();
            var adminAreaContext = new AreaRegistrationContext(adminArea.AreaName, routes);
            adminArea.RegisterArea(adminAreaContext);

            var defaultArea = new DefaultAreaRegistration();
            var defaultAreaContext = new AreaRegistrationContext(defaultArea.AreaName, routes);
            defaultArea.RegisterArea(defaultAreaContext);
        }
    }
}