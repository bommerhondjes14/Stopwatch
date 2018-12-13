using System.Collections.Generic;
using Newtonsoft.Json;
using RiotSharp.Endpoints.StaticDataEndpoint;

namespace Stopwatch.Core.Business.Domain.StaticEndpoint
{
    /// <summary>
    /// Class representing a spell of a champion (Static API).
    /// </summary>
    public class ChampionSpellStatic
    {
        internal ChampionSpellStatic() { }

        /// <summary>
        /// List of alternative images.
        /// </summary>
        public List<ImageStatic> Altimages { get; set; }

        /// <summary>
        /// List of the cooldowns for each level of the spell.
        /// </summary>
        public List<float> Cooldowns { get; set; }

        /// <summary>
        /// String representing the cooldowns for each level of the spell.
        /// </summary>
        public string CooldownBurn { get; set; }

        /// <summary>
        /// List of the costs for each level of the spell.
        /// </summary>
        public List<int> Costs { get; set; }

        /// <summary>
        /// String representing the costs for each level of the spell.
        /// </summary>
        public string CostBurn { get; set; }

        /// <summary>
        /// Type of cost (mana, energy, percentage of current health, etc).
        /// </summary>
        public string CostType { get; set; }

        /// <summary>
        /// Description of the spell.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Effects of the spell (damage, etc). This field is a List of List of Integer.
        /// </summary>
        public List<List<double>> Effects { get; set; }

        /// <summary>
        /// String representing the effects of the spell.
        /// </summary>
        public List<string> EffectBurns { get; set; }

        /// <summary>
        /// Image of the spell.
        /// </summary>
        public ImageStatic Image { get; set; }

        /// <summary>
        ///  String identifying a spell (champion's name + key to activate the spell, example: "AatroxQ".
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Tooltip when leveling up this spell.
        /// </summary>
        public LevelTipStatic LevelTip { get; set; }

        /// <summary>
        /// Maximum rank of this spell.
        /// </summary>
        public int MaxRank { get; set; }

        /// <summary>
        /// Name of this spell.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This field is either a List of Integer or the String 'self' for spells that target one's own champion.
        /// </summary>
        public object Range { get; set; }

        /// <summary>
        /// String representing the range for each level of the spell.
        /// </summary>
        public string RangeBurn { get; set; }

        /// <summary>
        /// String representing the cost for the champion when using this spell (example: "{{ e3 }}% of Current
        /// Health".
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Sanitized (HTML stripped) description of the spell.
        /// </summary>
        public string SanitizedDescription { get; set; }

        /// <summary>
        /// Sanitized (HTML stripped) tooltip of the spell.
        /// </summary>
        public string SanitizedTooltip { get; set; }

        /// <summary>
        /// Tooltip for this spell.
        /// </summary>
        public string Tooltip { get; set; }

        /// <summary>
        /// Various effects of this spell.
        /// </summary>
        public List<SpellVarsStatic> Vars { get; set; }
    }
}
