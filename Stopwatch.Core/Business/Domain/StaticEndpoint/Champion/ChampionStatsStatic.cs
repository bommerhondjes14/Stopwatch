using Newtonsoft.Json;

namespace Stopwatch.Core.Business.Domain.StaticEndpoint
{
    /// <summary>
    /// A few statistics of a champion (Static API).
    /// </summary>
    public class ChampionStatsStatic
    {
        internal ChampionStatsStatic() { }

        /// <summary>
        /// Base armor.
        /// </summary>
        public double Armor { get; set; }

        /// <summary>
        /// Armor won per level.
        /// </summary>
        public double ArmorPerLevel { get; set; }

        /// <summary>
        /// Base attack damage.
        /// </summary>
        public double AttackDamage { get; set; }

        /// <summary>
        /// Attack damage won per level.
        /// </summary>
        public double AttackDamagePerLevel { get; set; }

        /// <summary>
        /// Base attack range.
        /// </summary>
        public double AttackRange { get; set; }

        /// <summary>
        /// Base attack speed.
        /// </summary>
        public double AttackSpeedOffset { get; set; }

        /// <summary>
        /// Attack speed won per level.
        /// </summary>
        public double AttackSpeedPerLevel { get; set; }

        /// <summary>
        /// Base crit percentage.
        /// </summary>
        public double Crit { get; set; }

        /// <summary>
        /// Crit percentage won per level.
        /// </summary>
        public double CritPerLevel { get; set; }

        /// <summary>
        /// Base hit points.
        /// </summary>
        public double Hp { get; set; }

        /// <summary>
        /// Hit points won per level.
        /// </summary>
        public double HpPerLevel { get; set; }

        /// <summary>
        /// Base hit point regeneration.
        /// </summary>
        public double HpRegen { get; set; }

        /// <summary>
        /// Hit points regeneration per level.
        /// </summary>
        public double HpRegenPerLevel { get; set; }

        /// <summary>
        /// Base move speed.
        /// </summary>
        public double MoveSpeed { get; set; }

        /// <summary>
        /// Base mana points.
        /// </summary>
        public double Mp { get; set; }

        /// <summary>
        /// Mana points won per level.
        /// </summary>
        public double MpPerLevel { get; set; }

        /// <summary>
        /// Base mana point regeneration.
        /// </summary>
        public double MpRegen { get; set; }

        /// <summary>
        /// Mana point regeneration won per level.
        /// </summary>
        public double MpRegenPerLevel { get; set; }

        /// <summary>
        /// Base spell block.
        /// </summary>
        public double SpellBlock { get; set; }

        /// <summary>
        /// Spell block won per level.
        /// </summary>
        public double SpellBlockPerLevel { get; set; }
    }
}
