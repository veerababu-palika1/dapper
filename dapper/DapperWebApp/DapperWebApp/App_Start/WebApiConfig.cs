﻿using DapperWebApp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace DapperWebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            DependencyResolver.RegisterDependency(container);
            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
