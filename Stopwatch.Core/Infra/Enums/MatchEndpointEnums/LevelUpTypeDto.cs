using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Type of level up (Match API).
    /// </summary>
    public enum LevelUpTypeDto
    {
        /// <summary>
        /// When leveling up involves evolving (notably Kha'zix).
        /// </summary>
        Evolve,

        /// <summary>
        /// Normal leveling up.
        /// </summary>
        Normal
    }

    static class LevelUpTypeExtension
    {
        public static string ToCustomString(this LevelUpTypeDto levelUpType)
        {
            switch (levelUpType)
            {
                case LevelUpTypeDto.Evolve:
                    return "EVOLVE";
                case LevelUpTypeDto.Normal:
                    return "NORMAL";
                default:
                    return string.Empty;
            }
        }
    }
}
