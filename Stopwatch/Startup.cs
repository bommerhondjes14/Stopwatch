using System;
using Microsoft.Owin;
using Owin;
using Stopwatch.Models;

[assembly: OwinStartup(typeof(Stopwatch.Startup))]
namespace Stopwatch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
