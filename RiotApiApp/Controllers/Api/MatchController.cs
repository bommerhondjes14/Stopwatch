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
        public IHttpActionResult GetMatchListBySummonerName(string summonerName)
        {            
            IRiotClient client = new RiotClient();

            var summoner = client.GetSummonerBySummonerNameAsync(summonerName).Result;

            var queueTypes = new List<QueueType>();
            queueTypes.Add(QueueType.RANKED_FLEX_SR);

            var matchList = client.GetMatchListByAccountIdAsync(summoner.AccountId, rankedQueues: queueTypes, beginIndex: 0, endIndex: 10).Result;
            return Ok(matchList);
        }

        public IHttpActionResult GetMatchByGameId(long gameId)
        {
            IRiotClient client = new RiotClient();

            var match = client.GetMatchAsync(gameId).Result;
            return Ok(match);
        }
    }
}
