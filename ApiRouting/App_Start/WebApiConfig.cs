using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace ApiRouting
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
               name: "Flow",
               routeTemplate: "api/myrouting/athira/routing/{id}",
               defaults: new { controller = "routing", id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
              name: "Flow1",
              routeTemplate: "api/myrouting/athira1/routing/{str1}",
              defaults: new { controller = "routing", id = RouteParameter.Optional }
          );
        }
    }
}
