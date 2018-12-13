using System.Collections.Generic;
using Newtonsoft.Json;
using RiotSharp.Endpoints.StaticDataEndpoint.Champion;

namespace Stopwatch.Core.Business.Domain.StaticEndpoint
{
    /// <summary>
    /// Block of recommended items by type (starting, essential, offensive, etc) for a champion (Static API).
    /// </summary>
    public class BlockStatic
    {
        internal BlockStatic() { }

        /// <summary>
        /// List of recommended items.
        /// </summary>
        public List<BlockItemStatic> Items { get; set; }

        /// <summary>
        /// Rec math.
        /// </summary>
        public bool RecMath { get; set; }

        /// <summary>
        /// Type of items (starting, essential, offensive, etc).
        /// </summary>
        public string Type { get; set; }
    }
}
