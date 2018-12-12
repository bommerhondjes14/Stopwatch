using Stopwatch.Core.Business.Services.MatchEndpoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace Stopwatch.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here 
            // it is NOT necessary to register your controllers 

            // e.g. container.RegisterType<ITestService, TestService>(); 

            container.RegisterType<IMatchService, MatchService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}