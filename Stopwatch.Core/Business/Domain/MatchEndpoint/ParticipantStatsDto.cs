using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    /// <summary>
    /// Class gathering statistics about a participant (Match API).
    /// </summary>
    public class ParticipantStatsDto
    {
        internal ParticipantStatsDto() { }

        /// <summary>
        /// Number of assists.
        /// </summary>
        public long Assists { get; set; }

        /// <summary>
        /// Champion level achieved.
        /// </summary>
        public long ChampLevel { get; set; }

        /// <summary>
        /// If game was a dominion game, player's combat score, otherwise 0.
        /// </summary>
        public long CombatPlayerScore { get; set; }

        /// <summary>
        /// Number of deaths.
        /// </summary>
        public long Deaths { get; set; }

        /// <summary>
        /// Number of double kills.
        /// </summary>
        public long DoubleKills { get; set; }

        /// <summary>
        /// Flag indicating if participant got an assist on first blood.
        /// </summary>
        public bool FirstBloodAssist { get; set; }

        /// <summary>
        /// Flag indicating if participant got first blood.
        /// </summary>
        public bool FirstBloodKill { get; set; }

        /// <summary>
        /// Flag indicating if participant got an assist on the first inhibitor.
        /// </summary>
        public bool FirstInhibitorAssist { get; set; }

        /// <summary>
        /// Flag indicating if participant destroyed the first inhibitor.
        /// </summary>
        public bool FirstInhibitorKill { get; set; }

        /// <summary>
        /// Flag indicating if participant got an assist on the first tower.
        /// </summary>
        public bool FirstTowerAssist { get; set; }

        /// <summary>
        /// Flag indicating if participant destroyed the first tower.
        /// </summary>
        public bool FirstTowerKill { get; set; }

        /// <summary>
        /// Gold earned.
        /// </summary>
        public long GoldEarned { get; set; }

        /// <summary>
        /// Gold spent.
        /// </summary>
        public long GoldSpent { get; set; }

        /// <summary>
        /// Numer of inhibitor kills.
        /// </summary>
        public long InhibitorKills { get; set; }

        /// <summary>
        /// First item ID.
        /// </summary>
        public long Item0 { get; set; }

        /// <summary>
        /// Second item ID.
        /// </summary>
        public long Item1 { get; set; }

        /// <summary>
        /// Third item ID.
        /// </summary>
        public long Item2 { get; set; }

        /// <summary>
        /// Fourth item ID.
        /// </summary>
        public long Item3 { get; set; }

        /// <summary>
        /// Fifth item ID.
        /// </summary>
        public long Item4 { get; set; }

        /// <summary>
        /// Sixth item ID.
        /// </summary>
        public long Item5 { get; set; }

        /// <summary>
        /// Seventh item ID.
        /// </summary>
        public long Item6 { get; set; }

        /// <summary>
        /// Number of killing sprees.
        /// </summary>
        public long KillingSprees { get; set; }

        /// <summary>
        /// Number of kills.
        /// </summary>
        public long Kills { get; set; }

        /// <summary>
        /// Largest critical strike.
        /// </summary>
        public long LargestCriticalStrike { get; set; }

        /// <summary>
        /// Largest killing spree.
        /// </summary>
        public long LargestKillingSpree { get; set; }

        /// <summary>
        /// Largest multi kill.
        /// </summary>
        public long LargestMultiKill { get; set; }

        /// <summary>
        /// Magic damage dealt.
        /// </summary>
        public long MagicDamageDealt { get; set; }

        /// <summary>
        /// Magic damage dealt to champions.
        /// </summary>
        public long MagicDamageDealtToChampions { get; set; }

        /// <summary>
        /// Magic damage taken.
        /// </summary>
        public long MagicDamageTaken { get; set; }

        /// <summary>
        /// Minions kiled.
        /// </summary>
        public long MinionsKilled { get; set; }

        /// <summary>
        /// Neutral minions killed.
        /// </summary>
        public long NeutralMinionsKilled { get; set; }

        /// <summary>
        /// Neutral jungle minions killed in the enemy team's jungle.
        /// </summary>
        public long NeutralMinionsKilledEnemyJungle { get; set; }

        /// <summary>
        /// Neutral jungle minions killed in your team's jungle.
        /// </summary>
        public long NeutralMinionsKilledJungle { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node captures.
        /// </summary>
        public long NodeCapture { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node capture assists.
        /// </summary>
        public long NodeCaptureAssist { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node neutralizations.
        /// </summary>
        public long NodeNeutralize { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node neutralization assists.
        /// </summary>
        public long NodeNeutralizeAssist { get; set; }

        /// <summary>
        /// If game was a dominion game, player's objectives score, otherwise 0.
        /// </summary>
        public long ObjectivePlayerScore { get; set; }

        /// <summary>
        /// Number of penta kills.
        /// </summary>
        public long PentaKills { get; set; }

        /// <summary>
        /// Physical damage dealt.
        /// </summary>
        public long PhysicalDamageDealt { get; set; }

        /// <summary>
        /// Physical damage dealt to champions.
        /// </summary>
        public long PhysicalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Physical damage taken.
        /// </summary>
        public long PhysicalDamageTaken { get; set; }

        /// <summary>
        /// Number of quadra kills.
        /// </summary>
        public long QuadraKills { get; set; }

        /// <summary>
        /// Number of sight wards purchased.
        /// </summary>
        public long SightWardsBoughtInGame { get; set; }

        /// <summary>
        /// If game was a dominion game, number of completed team objectives (i.e., quests).
        /// </summary>
        public long TeamObjective { get; set; }

        /// <summary>
        /// Total damage dealt.
        /// </summary>
        public long TotalDamageDealt { get; set; }

        /// <summary>
        /// Total damage dealt to champions.
        /// </summary>
        public long TotalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Total damage taken.
        /// </summary>
        public long TotalDamageTaken { get; set; }

        /// <summary>
        /// Total heal.
        /// </summary>
        public long TotalHeal { get; set; }

        /// <summary>
        /// If game was a dominion game, player's total score, otherwise 0.
        /// </summary>
        public long TotalPlayerScore { get; set; }

        /// <summary>
        /// If game was a dominion game, team rank of the player's total score (e.g., 1-5).
        /// </summary>
        public long TotalScoreRank { get; set; }

        /// <summary>
        /// Total time crowd control dealt.
        /// </summary>
        public long TotalTimeCrowdControlDealt { get; set; }

        /// <summary>
        /// Total units healed.
        /// </summary>
        public long TotalUnitsHealed { get; set; }

        /// <summary>
        /// Number of tower kills.
        /// </summary>
        public long TowerKills { get; set; }

        /// <summary>
        /// Number of triple kills.
        /// </summary>
        public long TripleKills { get; set; }

        /// <summary>
        /// True damage dealt.
        /// </summary>
        public long TrueDamageDealt { get; set; }

        /// <summary>
        /// True damage dealt to champions.
        /// </summary>
        public long TrueDamageDealtToChampions { get; set; }

        /// <summary>
        /// True damage taken.
        /// </summary>
        public long TrueDamageTaken { get; set; }

        /// <summary>
        /// Number of unreal kills.
        /// </summary>
        public long UnrealKills { get; set; }

        /// <summary>
        /// Number of vision wards purchased.
        /// </summary>
        public long VisionWardsBoughtInGame { get; set; }

        /// <summary>
        /// Number of wards killed.
        /// </summary>
        public long WardsKilled { get; set; }

        /// <summary>
        /// Number of wards placed.
        /// </summary>
        public long WardsPlaced { get; set; }

        /// <summary>
        /// Flag indicating whether or not the participant won.
        /// </summary>
        public bool Winner { get; set; }
    }
}
