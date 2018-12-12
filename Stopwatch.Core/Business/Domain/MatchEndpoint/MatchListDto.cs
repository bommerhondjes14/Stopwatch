using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    public class MatchListDto
    {
        /// <summary>
        /// The end index of the list of matches.
        /// </summary>
        public int EndIndex { get; set; }

        /// <summary>
        /// List of matches for the player
        /// </summary>
        public List<MatchReferenceDto> Matches { get; set; }

        /// <summary>
        /// The start index of the list of matches.
        /// </summary>
        public int StartIndex { get; set; }

        /// <summary>
        /// Total number of games within the list.
        /// </summary>
        public int TotalGames { get; set; }
    }
}
