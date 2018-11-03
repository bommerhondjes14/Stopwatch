using RiotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RiotApiApp.Controllers.Api
{
    public class SummonerController : ApiController
    {
        public IHttpActionResult GetSummonerBySummonerName(string summonerName)
        {
            IRiotClient client = new RiotClient();
            var summoner = client.GetSummonerBySummonerNameAsync(summonerName).Result;

            return Ok(summoner);
        }
    }
}
