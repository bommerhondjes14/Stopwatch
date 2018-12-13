using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stopwatch.Core.Business.Domain.StaticEndpoint
{
    /// <summary>
    /// Class representing a list of champions (Static API).
    /// </summary>
    public class ChampionListStatic
    {
        internal ChampionListStatic() { }

        /// <summary>
        /// Map of champions indexed by their name.
        /// </summary>
        public Dictionary<string, ChampionStatic> Champions { get; set; }

        /// <summary>
        /// Format of the data retrieved (always null afaik).
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Map of the champions names indexed by their id.
        /// </summary>
        public Dictionary<int, string> Keys { get; set; }

        /// <summary>
        /// TAPI type (item).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Version of the API.
        /// </summary>
        public string Version { get; set; }
    }
}
