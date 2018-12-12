using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Type of tower (Match API).
    /// </summary>
    public enum TowerTypeDto
    {
        /// <summary>
        /// Represents inhibitor turrets.
        /// </summary>
        BaseTurret,

        /// <summary>
        /// Represents inner turrets.
        /// </summary>
        InnerTurret,

        /// <summary>
        /// Represents nexus turrets.
        /// </summary>
        NexusTurret,

        /// <summary>
        /// Represents outer turrets.
        /// </summary>
        OuterTurret,

        /// <summary>
        /// Undefined turrets?
        /// </summary>
        UndefinedTurret
    }

    static class TowerTypeExtension
    {
        public static string ToCustomString(this TowerTypeDto towerType)
        {
            switch (towerType)
            {
                case TowerTypeDto.BaseTurret:
                    return "BASE_TURRET";
                case TowerTypeDto.InnerTurret:
                    return "INNER_TURRET";
                case TowerTypeDto.NexusTurret:
                    return "NEXUS_TURRET";
                case TowerTypeDto.OuterTurret:
                    return "OUTER_TURRET";
                case TowerTypeDto.UndefinedTurret:
                    return "UNDEFINED_TURRET";
                default:
                    return string.Empty;
            }
        }
    }
}
