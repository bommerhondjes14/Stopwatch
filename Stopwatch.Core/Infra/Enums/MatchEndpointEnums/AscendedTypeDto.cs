using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Ascended type.
    /// </summary>
    public enum AscendedTypeDto
    {
        /// <summary>
        /// Champion ascended.
        /// </summary>
        ChampionAscended,

        /// <summary>
        /// Clear ascended.
        /// </summary>
        ClearAscended,

        /// <summary>
        /// Minion ascended.
        /// </summary>
        MinionAscended
    }

    static class AscendedTypeExtension
    {
        public static string ToCustomString(this AscendedTypeDto ascendedType)
        {
            switch (ascendedType)
            {
                case AscendedTypeDto.ChampionAscended:
                    return "CHAMPION_ASCENDED";
                case AscendedTypeDto.ClearAscended:
                    return "CLEAR_ASCENDED";
                case AscendedTypeDto.MinionAscended:
                    return "MINION_ASCENDED";
                default:
                    return string.Empty;
            }
        }
    }
}
