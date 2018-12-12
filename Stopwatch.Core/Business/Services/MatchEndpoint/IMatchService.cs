using Stopwatch.Core.Business.Domain.MatchEndpoint;
using Stopwatch.Core.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Services.MatchEndpoint
{
    public interface IMatchService
    {
        Task<MatchListDto> GetRecentMatchListAsync(RegionDto region, string summonerName);
        Task<MatchDto> GetMatchAsync(RegionDto region, long matchId);
    }
}
