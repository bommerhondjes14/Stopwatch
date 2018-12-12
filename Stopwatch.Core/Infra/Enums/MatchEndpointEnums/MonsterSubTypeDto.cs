using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Type of monster (Match API).
    /// </summary>
    public enum MonsterSubTypeDto
    {
        /// <summary>
        /// Corresponds to the cloud drake.
        /// </summary>
        AirDragon,

        /// <summary>
        /// Corresponds to the ocean drake.
        /// </summary>
        WaterDragon,

        /// <summary>
        /// Corresponds to the mountain drake.
        /// </summary>
        EarthDragon,

        /// <summary>
        /// Corresponds to the infernal drake.
        /// </summary>
        FireDragon,

        /// <summary>
        /// Corresponds to the elder dragon.
        /// </summary>
        ElderDragon
    }

    static class MonsterSubTypeExtension
    {
        public static string ToCustomString(this MonsterSubTypeDto monsterSubType)
        {
            switch (monsterSubType)
            {
                case MonsterSubTypeDto.AirDragon:
                    return "AIR_DRAGON";
                case MonsterSubTypeDto.WaterDragon:
                    return "WATER_DRAGON";
                case MonsterSubTypeDto.EarthDragon:
                    return "EARTH_DRAGON";
                case MonsterSubTypeDto.FireDragon:
                    return "FIRE_DRAGON";
                case MonsterSubTypeDto.ElderDragon:
                    return "ELDER_DRAGON";
                default:
                    return string.Empty;
            }
        }
    }
}
