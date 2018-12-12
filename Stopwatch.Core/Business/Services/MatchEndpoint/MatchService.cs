using AutoMapper;
using RiotSharp;
using RiotSharp.Endpoints.MatchEndpoint;
using RiotSharp.Endpoints.SummonerEndpoint;
using RiotSharp.Interfaces;
using RiotSharp.Misc;
using Stopwatch.Core.Business.Domain.MatchEndpoint;
using Stopwatch.Core.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Stopwatch.Core.Business.Services.MatchEndpoint
{
    public class MatchService : IMatchService
    {
        private IRiotApi _riotApi;

        public MatchService()
        {
            _riotApi = RiotApi.GetDevelopmentInstance(WebConfigurationManager.AppSettings["ApiKey"]);
        }

        public async Task<MatchListDto> GetRecentMatchListAsync(RegionDto regionDto, string summonerName)
        {
            Region region = Mapper.Map<Region>(regionDto);
            Summoner summoner = await _riotApi.Summoner.GetSummonerByNameAsync(region, summonerName);

            MatchList matchList = await _riotApi.Match.GetMatchListAsync(region, summoner.AccountId);
            
            return Mapper.Map<MatchListDto>(matchList);
        }

        public async Task<MatchDto> GetMatchAsync(RegionDto regionDto, long matchId)
        {
            Region region = Mapper.Map<Region>(regionDto);

            Match match = await _riotApi.Match.GetMatchAsync(region, matchId);
            return Mapper.Map<MatchDto>(match);
        }
    }
}
