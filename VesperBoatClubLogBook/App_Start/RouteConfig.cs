using System.Web.Mvc;
using System.Web.Routing;

namespace VesperBoatClubLogBook
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            // serves plane html
            routes.MapRoute("DefaultViews","{controller}/{action}/{id}",new { id = UrlParameter.Optional });
        }
    }
}
