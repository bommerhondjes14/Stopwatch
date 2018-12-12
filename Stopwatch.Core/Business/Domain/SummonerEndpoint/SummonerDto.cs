using System;
using RiotSharp.Misc.Converters;

namespace Stopwatch.Core.Business.Domain
{
    /// <summary>
    /// Class representing a Summoner in the API.
    /// </summary>
    public class SummonerDto : SummonerBaseDto
    {
        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        public int ProfileIconId { get; set; }

        /// <summary>
        /// Date summoner was last modified.
        /// </summary>
        public DateTime RevisionDate { get; set; }

        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        public long Level { get; set; }
    }
}
