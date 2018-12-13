using Newtonsoft.Json;
using RiotSharp.Endpoints.StaticDataEndpoint;

namespace Stopwatch.Core.Business.Domain.StaticEndpoint
{
    /// <summary>
    /// Class representing a champion's passive (Static API).
    /// </summary>
    public class PassiveStatic
    {
        internal PassiveStatic() { }

        /// <summary>
        /// String descripting the passive.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Image of the passive.
        /// </summary>
        public ImageStatic Image { get; set; }

        /// <summary>
        /// Name of the passive.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sanitized (HTML stripped) description of the passive.
        /// </summary>
        public string SanitizedDescription { get; set; }
    }
}
