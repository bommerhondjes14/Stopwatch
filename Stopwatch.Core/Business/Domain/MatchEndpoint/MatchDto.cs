using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Match class containing all properties to define a match.
    /// </summary>
    public class MatchDto
    {
        /// <summary>
        /// The season ID.
        /// </summary>
        public int SeasonId { get; set; }

        /// <summary>
        /// Specifies the Queue ID.
        /// </summary>
        public int QueueId { get; set; }

        /// <summary>
        /// Equivalent to match id
        /// </summary>
        public long GameId { get; set; }

        /// <summary>
        /// The participants identities.
        /// </summary>
        public List<ParticipantIdentityDto> ParticipantIdentities { get; set; }

        /// <summary>
        /// The game version.
        /// </summary>
        public string GameVersion { get; set; }

        /// <summary>
        /// The game mode.
        /// </summary>
        public string GameMode { get; set; }

        /// <summary>
        /// The map ID.
        /// </summary>
        public int MapId { get; set; }

        /// <summary>
        /// The game type.
        /// </summary>
        public string GameType { get; set; }

        /// <summary>
        /// The teams.
        /// </summary>
        public List<TeamStatsDto> Teams { get; set; }

        /// <summary>
        /// The participants.
        /// </summary>
        public List<ParticipantDto> Participants { get; set; }

        /// <summary>
        /// The game duration.
        /// </summary>
        public TimeSpan GameDuration { get; set; }

        /// <summary>
        /// The date time of the game creation.
        /// </summary>
        public DateTime GameCreation { get; set; }
    }
}
