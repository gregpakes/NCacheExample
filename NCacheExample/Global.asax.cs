using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NCacheExample;

[assembly:PreApplicationStartMethod(typeof(ApplicationStart), "Startup")]

namespace NCacheExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }

    public class ApplicationStart
    {
        public static void Startup()
        {
            // Perform application initialization here - in my case setup DI container and configure/prime cache
            var cache = Alachisoft.NCache.Web.Caching.NCache.InitializeCache("myCache");
        }
    }
}
