using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class representing a match's timeline (Match API).
    /// </summary>
    public class MatchTimelineDto
    {
        internal MatchTimelineDto() { }

        /// <summary>
        /// Time between each returned frame.
        /// </summary>
        public TimeSpan FrameInterval { get; set; }

        /// <summary>
        /// List of timeline frames for the game.
        /// </summary>
        public List<FrameDto> Frames { get; set; }
    }
}
