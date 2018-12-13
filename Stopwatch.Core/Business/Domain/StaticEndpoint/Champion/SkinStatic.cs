using Newtonsoft.Json;

namespace Stopwatch.Core.Business.Domain.StaticEndpoint
{
    /// <summary>
    /// Class representing a skin of a champion (Static API).
    /// </summary>
    public class SkinStatic
    {
        internal SkinStatic() { }

        /// <summary>
        /// Id of the skin.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the skin.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ordered number of the skin.
        /// </summary>
        public int Num { get; set; }
    }
}
