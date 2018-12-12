using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class holding timeline values (Match API).
    /// </summary>
    public class ParticipantTimelineDataDto
    {
        internal ParticipantTimelineDataDto() { }

        /// <summary>
        /// Value per minute from 10 min to 20 min.
        /// </summary>
        public double TenToTwenty { get; set; }

        /// <summary>
        /// Value per minute from 30 min to the end of the game.
        /// </summary>
        public double ThirtyToEnd { get; set; }

        /// <summary>
        /// Value per minute from 20 min to 30 min.
        /// </summary>
        public double TwentyToThirty { get; set; }

        /// <summary>
        /// Value per minute from the beginning of the game to 10 min.
        /// </summary>
        public double ZeroToTen { get; set; }
    }
}
