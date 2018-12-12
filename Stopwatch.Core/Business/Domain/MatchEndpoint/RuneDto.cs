using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class representing a rune of a participant (Match API).
    /// </summary>
    public class RuneDto
    {
        internal RuneDto() { }

        /// <summary>
        /// Rune rank.
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Rune ID.
        /// </summary>
        public int RuneId { get; set; }
    }
}
