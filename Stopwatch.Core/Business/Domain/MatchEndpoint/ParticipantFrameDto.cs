using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class representing a particular frame for a participant during a match (Match API).
    /// </summary>
    public class ParticipantFrameDto
    {
        internal ParticipantFrameDto() { }

        /// <summary>
        /// Participant's current gold.
        /// </summary>
        public int CurrentGold { get; set; }

        /// <summary>
        /// Number of jungle minions killed by participant.
        /// </summary>
        public int JungleMinionsKilled { get; set; }

        /// <summary>
        /// Participant's current level.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Number of minions killed by participant.
        /// </summary>
        public int MinionsKilled { get; set; }

        /// <summary>
        /// Participant ID.
        /// </summary>
        public int ParticipantId { get; set; }

        /// <summary>
        /// Participant's position.
        /// </summary>
        public PositionDto Position { get; set; }

        /// <summary>
        /// Participant's total gold.
        /// </summary>
        public int TotalGold { get; set; }

        /// <summary>
        /// Experience earned by participant.
        /// </summary>
        public int XP { get; set; }
    }
}
