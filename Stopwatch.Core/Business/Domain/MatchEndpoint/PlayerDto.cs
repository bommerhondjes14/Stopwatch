using Stopwatch.Core.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    public class PlayerDto
    {
        internal PlayerDto() { }

        /// <summary>
        /// Current platform ID.
        /// </summary>
        public PlatformDto CurrentPlatformId { get; set; }

        /// <summary>
        /// Platform ID.
        /// </summary>
        public PlatformDto PlatformId { get; set; }

        /// <summary>
        /// Match history URI.
        /// </summary>
        public string MatchHistoryUri { get; set; }

        /// <summary>
        /// Profile icon ID.
        /// </summary>
        public int ProfileIcon { get; set; }

        /// <summary>
        /// Current account ID.
        /// </summary>
        public long CurrentAccountId { get; set; }

        /// <summary>
        /// Account ID.
        /// </summary>
        public long AccountId { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        public long SummonerId { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        public string SummonerName { get; set; }
    }
}
