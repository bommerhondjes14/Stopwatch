using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class representing a frame in a match (Match API).
    /// </summary>
    public class FrameDto
    {
        internal FrameDto() { }

        /// <summary>
        /// List of events for this frame.
        /// </summary>
        public List<EventDto> Events { get; set; }

        /// <summary>
        /// Map of each participant ID to the participant's information for the frame.
        /// </summary>
        public Dictionary<string, ParticipantFrameDto> ParticipantFrames { get; set; }

        /// <summary>
        /// Represents how much time into the game the frame occurred.
        /// </summary>
        public TimeSpan Timestamp { get; set; }
    }
}
