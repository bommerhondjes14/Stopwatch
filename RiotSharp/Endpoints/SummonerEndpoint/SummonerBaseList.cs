﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotSharp.Endpoints.SummonerEndpoint
{
    public class SummonerBaseList
    {
        [JsonProperty("summoners")]
        public List<SummonerBase> Summoners { get; set; }
    }
}
