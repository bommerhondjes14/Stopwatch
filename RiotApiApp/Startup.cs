using System;
using Microsoft.Owin;
using Owin;
using RiotApiApp.Models;
using RiotNet;
using RiotNet.Models;

[assembly: OwinStartupAttribute(typeof(RiotApiApp.Startup))]
namespace RiotApiApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            SetDefaultSettings();
        }

        private void SetDefaultSettings()
        {
            ApiKey key = new ApiKey();
            RiotClient.DefaultPlatformId = PlatformId.EUW1;
            RiotClient.DefaultSettings = () => new RiotClientSettings
            {
                ApiKey = key.Api_Key // Replace this with your API key, of course.
            };
        }
    }
}
