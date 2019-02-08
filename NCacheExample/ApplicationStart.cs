using System.Web;
using NCacheExample;

[assembly: PreApplicationStartMethod(typeof(ApplicationStart), "Startup")]

namespace NCacheExample
{
    public class ApplicationStart
    {
        public static void Startup()
        {
            // Perform application initialization here - in my case setup DI container and configure/prime cache
            var cache = Alachisoft.NCache.Web.Caching.NCache.InitializeCache("myCache");
        }
    }
}