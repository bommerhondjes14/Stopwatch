using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Details about a match (Match API).
    /// </summary>
    public class MatchDetailDto : MatchSummaryDto
    {
        internal MatchDetailDto() { }

        /// <summary>
        /// Team information.
        /// </summary>
        public List<TeamStatsDto> Teams { get; set; }

        /// <summary>
        /// Match timeline data. Not included by default.
        /// </summary>
        public MatchTimelineDto Timeline { get; set; }
    }
}
