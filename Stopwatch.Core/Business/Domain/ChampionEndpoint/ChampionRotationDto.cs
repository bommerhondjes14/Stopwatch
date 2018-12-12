using System.Collections.Generic;

namespace Stopwatch.Core.Business.Domain.ChampionEndpoint
{
    /// <summary>
    /// Class representing Champions in the current rotation in the API.
    /// </summary>
    public class ChampionRotationDto
    {

        /// <summary>
        /// List of free champions.
        /// </summary>
        public List<int> FreeChampionIds { get; set; }

        /// <summary>
        /// List of free champions for new players.
        /// </summary>
        public List<int> FreeChampionIdsForNewPlayers { get; set; }

        /// <summary>
        /// Current max new player level.
        /// </summary>
        public int MaxNewPlayerLevel { get; set; }
    }
}
