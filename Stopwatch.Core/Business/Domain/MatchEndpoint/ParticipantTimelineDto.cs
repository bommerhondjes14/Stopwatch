using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    public class ParticipantTimelineDto
    {
        /// <summary>
        /// The lane of the participant.
        /// </summary>
        public string Lane { get; set; }

        /// <summary>
        /// The role of the participant.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// The participant ID.
        /// </summary>
        public int ParticipantId { get; set; }

        public Dictionary<string, double> GoldPerMinDeltas { get; set; }

        public Dictionary<string, double> XpDiffPerMinDeltas { get; set; }

        public Dictionary<string, double> XpPerMinDeltas { get; set; }

        public Dictionary<string, double> CsDiffPerMinDeltas { get; set; }

        public Dictionary<string, double> CreepsPerMinDeltas { get; set; }

        public Dictionary<string, double> DamageTakenDiffPerMinDeltas { get; set; }

        public Dictionary<string, double> DamageTakenPerMinDeltas { get; set; }
    }
}
