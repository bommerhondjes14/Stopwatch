using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class representing a participant's identity in a match (Match API).
    /// </summary>
    public class ParticipantIdentityDto
    {
        internal ParticipantIdentityDto() { }

        /// <summary>
        /// Participant ID.
        /// </summary>
        public int ParticipantId { get; set; }

        /// <summary>
        /// Player information.
        /// </summary>
        public PlayerDto Player { get; set; }
    }
}
