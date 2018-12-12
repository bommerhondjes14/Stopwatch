using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    public class TeamBanDto
    {
        internal TeamBanDto() { }

        /// <summary>
        /// The pick turn where the champion has been banned.
        /// </summary>
        public int PickTurn { get; set; }

        /// <summary>
        /// ID of the banned champion.
        /// </summary>
        public int ChampionId { get; set; }
    }
}
