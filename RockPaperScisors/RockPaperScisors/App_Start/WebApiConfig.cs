using Autofac;
using Autofac.Integration.WebApi;
using RockPaperScisors.Contracts.ServiceLibrary;
using RockPaperScisors.Impl.ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RockPaperScisors
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<UserAppService>().As<IUserAppService>();
            containerBuilder.RegisterType<GameAppService>().As<IGameAppService>();
            containerBuilder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(containerBuilder.Build());

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
