using AutoMapper;
using RiotSharp.Endpoints.MatchEndpoint;
using RiotSharp.Endpoints.SummonerEndpoint;
using RiotSharp.Misc;
using Stopwatch.Core.Business.Domain;
using Stopwatch.Core.Business.Domain.MatchEndpoint;
using Stopwatch.Core.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stopwatch.Core
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                // Global Enums
                cfg.CreateMap<Region, RegionDto>();

                // SummonerEndpoint
                cfg.CreateMap<Summoner, SummonerDto>();
                cfg.CreateMap<SummonerBase, SummonerBaseDto>();
                cfg.CreateMap<SummonerBaseList, SummonerBaseListDto>();

                // MatchEndpoint
                cfg.CreateMap<Match, MatchDto>();
                cfg.CreateMap<Participant, ParticipantDto>();
                cfg.CreateMap<TeamStats, TeamStatsDto>();
            });
        }
    }
}