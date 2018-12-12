using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class representing a banned champion (Game API).
    /// </summary>
    public class BannedChampionDto
    {
        internal BannedChampionDto() { }

        /// <summary>
        /// Banned champion ID.
        /// </summary>
        public int ChampionId { get; set; }

        /// <summary>
        /// Turn during which the champion was banned.
        /// </summary>
        public int PickTurn { get; set; }
    }
}
