using RiotSharp;
using RiotSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Stopwatch.Core.Business.Services.ChampionEndpoint
{
    public class ChampionService
    {
        private IRiotApi _riotApi;

        public ChampionService()
        {
            _riotApi = RiotApi.GetDevelopmentInstance(WebConfigurationManager.AppSettings["ApiKey"]);
        }
    }
}
