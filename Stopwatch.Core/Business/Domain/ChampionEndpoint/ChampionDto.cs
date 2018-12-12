
namespace Stopwatch.Core.Business.Domain.ChampionEndpoint
{
    /// <summary>
    /// Class representing a Champion in the API.
    /// </summary>
    public class ChampionDto
    {
        internal ChampionDto() { }

        /// <summary>
        /// Indicates if the champion is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Bot enabled flag (for custom games).
        /// </summary>
        public bool BotEnabled { get; set; }

        /// <summary>
        /// Bot Match Made enabled flag (for Co-op vs. AI games).
        /// </summary>
        public bool BotMmEnabled { get; set; }

        /// <summary>
        /// Indicates if the champion is free to play. Free to play champions are rotated periodically.
        /// </summary>
        public bool FreeToPlay { get; set; }

        /// <summary>
        /// Champion ID.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Ranked play enabled flag.
        /// </summary>
        public bool RankedPlayEnabled { get; set; }
    }
}
