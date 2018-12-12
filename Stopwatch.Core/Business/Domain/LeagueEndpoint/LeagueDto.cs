using Stopwatch.Core.Infra.Enums.LeagueEndpointEnums;
using System.Collections.Generic;

namespace Stopwatch.Core.Business.Domain.LeagueEndpoint
{
    /// <summary>
    /// Class representing a League in the API.
    /// </summary>
    public class LeagueDto
    {
        internal LeagueDto() { }

        /// <summary>
        /// The requested league entries.
        /// </summary>
        public List<LeaguePositionDto> Entries { get; set; }

        /// <summary>
        /// This name is an internal place-holder name only.
        /// Display and localization of names in the game client are handled client-side.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// League queue (eg: RankedSolo5x5).
        /// </summary>
        public string Queue { get; set; }

        /// <summary>
        /// League tier (eg: Challenger).
        /// </summary>
        public Tier Tier { get; set; }
    }
}
