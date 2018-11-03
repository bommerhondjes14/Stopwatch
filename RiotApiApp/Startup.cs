using System;
using Microsoft.Owin;
using Owin;
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
            RiotClient.DefaultPlatformId = PlatformId.EUW1;
            RiotClient.DefaultSettings = () => new RiotClientSettings
            {
                ApiKey = "RGAPI-5bbe0674-ef30-48ed-b5a1-9612ac3864d8" // Replace this with your API key, of course.
            };
        }
    }
}
