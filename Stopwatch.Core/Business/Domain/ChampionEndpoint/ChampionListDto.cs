using System.Collections.Generic;

namespace Stopwatch.Core.Business.Domain.ChampionEndpoint
{
    class ChampionListDto
    {
        /// <summary>
        /// List of Champions.
        /// </summary>
        public List<ChampionDto> Champions { get; set; }
    }
}
