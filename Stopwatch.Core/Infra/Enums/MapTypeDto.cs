using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Infra.Enums
{
    /// <summary>
    /// Map of the game. Populate the mapId field
    /// </summary>
    public enum MapTypeDto
    {
        /// <summary>
        /// Summoner's Rift Summer Variant
        /// </summary>
        SummonersRiftSummerVariant = 1,

        /// <summary>
        /// Summoner's Rift Autumn Variant
        /// </summary>
        SummonersRiftAutumnVariant = 2,

        /// <summary>
        /// The Proving Grounds Tutorial Map
        /// </summary>
        TheProvingGrounds = 3,

        /// <summary>
        /// Twisted Treeline Original Version
        /// </summary>
        TwistedTreelineOriginal = 4,

        /// <summary>
        ///The Crystal Scar Dominion Map
        /// </summary>
        TheCrystalScar = 8,

        /// <summary>
        /// Twisted Treeline Current Version
        /// </summary>
        TwistedTreelineCurrent = 10,

        /// <summary>
        /// Summoner's Rift Current Version
        /// </summary>
        SummonersRift = 11,

        /// <summary>
        /// Howling Abyss ARAM Map
        /// </summary>
        HowlingAbyss = 12,

        /// <summary>
        /// Darkstar Map
        /// </summary>
        CosmicRuins = 16
    }
}
