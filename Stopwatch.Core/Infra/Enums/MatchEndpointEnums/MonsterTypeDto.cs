
namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Type of monster (Match API).
    /// </summary>
    public enum MonsterTypeDto
    {
        /// <summary>
        /// Corresponds to the baron Nashor.
        /// </summary>
        BaronNashor,

        /// <summary>
        /// Corresponds to the blue golem.
        /// </summary>
        BlueGolem,

        /// <summary>
        /// Corresponds to the dragon.
        /// </summary>
        Dragon,

        /// <summary>
        /// Corresponds to the red lizard.
        /// </summary>
        RedLizard,

        /// <summary>
        /// Corresponds to Vilemaw (on the 3vs3 map).
        /// </summary>
        Vilemaw,

        /// <summary>
        /// Corresponds to Rift Herald.
        /// </summary>
        RiftHerald
    }

    static class MonsterTypeExtension
    {
        public static string ToCustomString(this MonsterTypeDto monsterType)
        {
            switch (monsterType)
            {
                case MonsterTypeDto.BaronNashor:
                    return "BARON_NASHOR";
                case MonsterTypeDto.BlueGolem:
                    return "BLUE_GOLEM";
                case MonsterTypeDto.Dragon:
                    return "DRAGON";
                case MonsterTypeDto.RedLizard:
                    return "RED_LIZARD";
                case MonsterTypeDto.Vilemaw:
                    return "VILEMAW";
                case MonsterTypeDto.RiftHerald:
                    return "RIFTHERALD";
                default:
                    return string.Empty;
            }
        }
    }
}
