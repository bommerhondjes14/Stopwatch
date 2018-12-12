using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class representing a mastery of a participant (Match API).
    /// </summary>
    public class MasteryDto
    {
        internal MasteryDto() { }

        /// <summary>
        /// Mastery ID.
        /// </summary>
        public int MasteryId { get; set; }

        /// <summary>
        /// Mastery rank.
        /// </summary>
        public int Rank { get; set; }
    }
}
