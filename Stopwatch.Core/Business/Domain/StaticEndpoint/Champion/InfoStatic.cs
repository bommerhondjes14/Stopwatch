using Newtonsoft.Json;

namespace Stopwatch.Core.Business.Domain.StaticEndpoint
{
    /// <summary>
    /// Basic information for a champion (Static API).
    /// </summary>
    public class InfoStatic
    {
        internal InfoStatic() { }

        /// <summary>
        /// Number between 1 and 10 representing the attack power of a champion.
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// Number between 1 and 10 representing the defense power of a champion.
        /// </summary>
        public int Defense { get; set; }

        /// <summary>
        /// Number between 1 and 10 representing the difficulty of a champion.
        /// </summary>
        public int Difficulty { get; set; }

        /// <summary>
        /// Number between 1 and 10 representing the magic power of a champion.
        /// </summary>
        public int Magic { get; set; }
    }
}
