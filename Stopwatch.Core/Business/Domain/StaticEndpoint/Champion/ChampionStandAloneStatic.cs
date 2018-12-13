using System.Collections.Generic;

namespace Stopwatch.Core.Business.Domain.StaticEndpoint
{
    public class ChampionStandAloneStatic
    {
        public string Type { get; set; }
        public string Format { get; set; }
        public string Version { get; set; }
        public Dictionary<string, ChampionStatic> Data { get; set; }
    }
}
