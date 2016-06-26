using Autofac;
using Autofac.Integration.WebApi;
using RockPaperScissors.ADO.DB.Infrastructure;
using RockPaperScissors.Contract.ServiceLibrary;
using RockPaperScissors.Impl.ServiceLibrary;
using RockPaperScissors.Impl.ServiceLibrary.Repositories;
using RockPaperScissors.Impl.ServiceLibrary.Services;
using System.Reflection;
using System.Web.Http;

namespace RockPaperScissors.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            containerBuilder.RegisterType<UserAppService>().As<IUserAppService>();
            containerBuilder.RegisterType<GameAppService>().As<IGameAppService>();
            containerBuilder.RegisterType<RockPaperScissorsRepository>().As<IRockPaperScissorsRepository>();
            //containerBuilder.RegisterType<AutoMapper.Mapper>(
            //    new MapperConfiguration).As<AutoMapper.IMapper>().SingleInstance();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(containerBuilder.Build());


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "GameAPI",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
