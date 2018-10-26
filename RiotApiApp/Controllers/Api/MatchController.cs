using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using RiotApiApp.Models;
using RiotNet;
using RiotNet.Models;

namespace RiotApiApp.Controllers.Api
{
    public class MatchController : ApiController
    {
        public async Task<IHttpActionResult> GetMatchListBySummonerName(string summonerName)
        {
            RiotClient.DefaultPlatformId = PlatformId.EUW1;
            RiotClient.DefaultSettings = () => new RiotClientSettings
            {
                ApiKey = "RGAPI-1da5c450-e1cd-4bf9-bf29-0b243cada9bf" // Replace this with your API key, of course.
            };
            IRiotClient client = new RiotClient();
            //var summoner = client.GetSummonerBySummonerNameAsync(summonerName).Result;
            //var queueTypes = new List<QueueType>();
            //queueTypes.Add(QueueType.RANKED_FLEX_SR);
            //var matchList = client.GetMatchListByAccountIdAsync(summoner.AccountId, rankedQueues: queueTypes).Result;
            return Ok();
        }
    }
}
