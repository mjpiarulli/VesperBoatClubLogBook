﻿using System.Web.Http;

namespace VesperBoatClubLogBook
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling 
                = Newtonsoft.Json.ReferenceLoopHandling.Ignore; 

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{action}/{id}",
                new { id = RouteParameter.Optional }
            );
        }
    }
}
