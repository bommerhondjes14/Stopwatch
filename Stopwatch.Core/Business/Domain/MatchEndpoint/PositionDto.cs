using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Participant's position (Match API).
    /// </summary>
    public class PositionDto
    {
        internal PositionDto() { }

        /// <summary>
        /// Participant's X coordinate.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Participant's Y coordinate.
        /// </summary>
        public int Y { get; set; }
    }
}
