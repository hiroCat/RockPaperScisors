using Autofac;
using RockPaperScisors.Contracts.ServiceLibrary;
using RockPaperScisors.Impl.ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace RockPaperScisors
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

        }
       
    }

}
