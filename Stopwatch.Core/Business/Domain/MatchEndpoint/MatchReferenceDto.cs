using RiotSharp.Endpoints.MatchEndpoint.Enums;
using Stopwatch.Core.Infra;
using Stopwatch.Core.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    public class MatchReferenceDto
    {
        /// <summary>
        /// The ID of the champion played during the match.
        /// </summary>
        public long ChampionID { get; set; }

        /// <summary>
        /// Participant's lane.
        /// </summary>
        public LaneDto Lane { get; set; }

        /// <summary>
        /// The match ID relating to the match.
        /// </summary>
        public long GameId { get; set; }

        /// <summary>
        /// The ID of the platform on which the game is being played
        /// </summary>
        public PlatformDto PlatformID { get; set; }

        /// <summary>
        /// Match queue type.
        /// </summary>
        public int Queue { get; set; }

        /// <summary>
        /// The region match was played in.
        /// </summary>
        public RegionDto Region { get; set; }

        /// <summary>
        /// Participant's role.
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Season match was played.
        /// </summary>
        public Season Season { get; set; }

        /// <summary>
        /// The date/time of which the game lobby was created.
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}
