using Newtonsoft.Json;

namespace Stopwatch.Core.Business.Domain.StaticEndpoint.Champion
{
    /// <summary>
    /// Recommended items in a block (starting, essential, offensive, etc) for a champion (Static API).
    /// </summary>
    public class BlockItemStatic
    {
        internal BlockItemStatic() { }

        /// <summary>
        /// Recommended count.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Id of the recommended item.
        /// </summary>
        public string Id { get; set; }
    }
}
