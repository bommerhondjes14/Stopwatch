using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class representing a team in a match (Match API).
    /// </summary>
    public class TeamStatsDto
    {
        internal TeamStatsDto() { }

        /// <summary>
        /// If game was draft mode, contains banned champion data, otherwise null.
        /// </summary>
        public List<TeamBanDto> Bans { get; set; }

        /// <summary>
        /// Number of times the team killed baron.
        /// </summary>
        public int BaronKills { get; set; }

        /// <summary>
        /// If game was a dominion game, specifies the points the team had at game end, otherwise null.
        /// </summary>
        public long DominionVictoryScore { get; set; }

        /// <summary>
        /// Number of times the team killed dragon.
        /// </summary>
        public int DragonKills { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team got the first baron kill.
        /// </summary>
        public bool FirstBaron { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team got first blood.
        /// </summary>
        public bool FirstBlood { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team got the first dragon kill.
        /// </summary>
        public bool FirstDragon { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team destroyed the first inhibitor.
        /// </summary>
        public bool FirstInhibitor { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team killed the first rift herald.
        /// </summary>
        public bool FirstRiftHerald { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team destroyed the first tower.
        /// </summary>
        public bool FirstTower { get; set; }

        /// <summary>
        /// Number of inhibitors the team destroyed.
        /// </summary>
        public int InhibitorKills { get; set; }

        /// <summary>
        /// Number of rift heralds killed.
        /// </summary>
        public int RiftHeraldKills { get; set; }

        /// <summary>
        /// Team ID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// Number of towers the team destroyed.
        /// </summary>
        public int TowerKills { get; set; }

        /// <summary>
        /// Number of times the team killed vilemaw (Twisted Treeline epic monster).
        /// </summary>
        public int VilemawKills { get; set; }

        /// <summary>
        /// A string indicating whether or not the team won.
        /// </summary>
        public string Win { get; set; }
    }
}
