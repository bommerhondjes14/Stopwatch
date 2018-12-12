using Stopwatch.Core.Infra.Enums;
using Stopwatch.Core.Infra.Enums.MatchEndpointEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Summary of a match (Match API).
    /// </summary>
    public class MatchSummaryDto
    {
        internal MatchSummaryDto() { }

        /// <summary>
        /// Map type.
        /// </summary>
        public MapTypeDto MapType { get; set; }

        /// <summary>
        /// Match creation time. Designates when the team select lobby is created and/or the match is made through
        /// match making, not when the game actually starts.
        /// </summary>
        public DateTime MatchCreation { get; set; }

        /// <summary>
        /// Match duration.
        /// </summary>
        public TimeSpan MatchDuration { get; set; }

        /// <summary>
        /// Match ID.
        /// </summary>
        public long MatchId { get; set; }

        /// <summary>
        /// Match mode.
        /// </summary>
        public string MatchMode { get; set; }

        /// <summary>
        /// Defines what GameType the match is eg. Custom, Matched, Tutorial.
        /// </summary>
        public GameTypeDto MatchType { get; set; }

        /// <summary>
        /// Match version.
        /// </summary>
        public string MatchVersion { get; set; }

        /// <summary>
        /// Participants identity information.
        /// </summary>
        public List<ParticipantIdentityDto> ParticipantIdentities { get; set; }

        /// <summary>
        /// Participants information
        /// </summary>
        public List<ParticipantDto> Participants { get; set; }

        /// <summary>
        /// Match queue type.
        /// </summary>
        public string QueueType { get; set; }

        /// <summary>
        /// Region where the match was played.
        /// </summary>
        public RegionDto Region { get; set; }

        /// <summary>
        /// Season match was played.
        /// </summary>
        public SeasonDto Season { get; set; }
    }
}
