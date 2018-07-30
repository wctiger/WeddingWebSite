using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WeddingAPI.CORS;
using WeddingAPI.Filters;

namespace WeddingAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.SetCorsPolicyProviderFactory(new CorsPolicyFactory());
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new MyExceptionFilter());
        }
    }
}
