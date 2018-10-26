using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RiotApiApp.Startup))]
namespace RiotApiApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
