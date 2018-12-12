using Stopwatch.Core.Infra.Enums.LeagueEndpointEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class representing a participant in a match (Match API).
    /// </summary>
    public class ParticipantDto
    {
        internal ParticipantDto() { }

        /// <summary>
        /// Champion ID.
        /// </summary>
        public int ChampionId { get; set; }

        /// <summary>
        /// List of mastery information.
        /// </summary>
        public List<MasteryDto> Masteries { get; set; }

        /// <summary>
        /// Participant ID.
        /// </summary>
        public int ParticipantId { get; set; }

        /// <summary>
        /// List of rune information.
        /// </summary>
        public List<RuneDto> Runes { get; set; }

        /// <summary>
        /// First summoner spell ID.
        /// </summary>
        public int Spell1Id { get; set; }

        /// <summary>
        /// Second summoner spell ID.
        /// </summary>
        public int Spell2Id { get; set; }

        /// <summary>
        /// Participant statistics.
        /// </summary>
        public ParticipantStatsDto Stats { get; set; }

        /// <summary>
        /// Team ID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// Timeline data.
        /// </summary>
        public ParticipantTimelineDto Timeline { get; set; }

        /// <summary>
        /// Highest achieved season tier.
        /// </summary>
        public Tier HighestAchievedSeasonTier { get; set; }
    }
}
