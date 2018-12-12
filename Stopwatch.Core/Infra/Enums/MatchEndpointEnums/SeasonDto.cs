using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Season (Match API).
    /// </summary>
    public enum SeasonDto
    {
        /// <summary>
        /// Pre season 3.
        /// </summary>
        PreSeason3 = 0,

        /// <summary>
        /// Season 3.
        /// </summary>
        Season3 = 1,

        /// <summary>
        /// Pre season 2014.
        /// </summary>
        PreSeason2014 = 2,

        /// <summary>
        /// Season 2014.
        /// </summary>
        Season2014 = 3,

        /// <summary>
        /// Pre season 2015.
        /// </summary>
        PreSeason2015 = 4,

        /// <summary>
        /// Season 2015.
        /// </summary>
        Season2015 = 5,

        /// <summary>
        /// Pre season 2016.
        /// </summary>
        PreSeason2016 = 6,

        /// <summary>
        /// Season 2016.
        /// </summary>
        Season2016 = 7,

        /// <summary>
        /// Pre season 2017.
        /// </summary>
        PreSeason2017 = 8,

        /// <summary>
        /// Season 2017.
        /// </summary>
        Season2017 = 9,
        
        /// <summary>
        /// Pre season 2018.
        /// </summary>
        PreSeason2018 = 10,
        
        /// <summary>
        /// Season 2018.
        /// </summary>
        Season2018 = 11
    }

    static class SeasonExtension
    {
        public static string ToCustomString(this SeasonDto season)
        {
            switch (season)
            {
                case SeasonDto.PreSeason3:
                    return "PRESEASON3";
                case SeasonDto.Season3:
                    return "SEASON3";
                case SeasonDto.PreSeason2014:
                    return "PRESEASON2014";
                case SeasonDto.Season2014:
                    return "SEASON2014";
                case SeasonDto.PreSeason2015:
                    return "PRESEASON2015";
                case SeasonDto.Season2015:
                    return "SEASON2015";
                case SeasonDto.PreSeason2016:
                    return "PRESEASON2016";
                case SeasonDto.Season2016:
                    return "SEASON2016";
                case SeasonDto.PreSeason2017:
                    return "PRESEASON2017";
                case SeasonDto.Season2017:
                    return "SEASON2017";
                case SeasonDto.PreSeason2018:
                    return "PRESEASON2018";
                case SeasonDto.Season2018:
                    return "SEASON2018";
                default:
                    return string.Empty;
            }
        }
    }
}
