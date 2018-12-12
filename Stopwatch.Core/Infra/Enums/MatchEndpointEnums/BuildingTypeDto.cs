using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Building type (Match API).
    /// </summary>
    public enum BuildingTypeDto
    {
        /// <summary>
        /// Inhibitors.
        /// </summary>
        InhibitorBuilding,

        /// <summary>
        /// Towers.
        /// </summary>
        TowerBuilding
    }

    static class BuildingTypeExtension
    {
        public static string ToCustomString(this BuildingTypeDto buildingType)
        {
            switch (buildingType)
            {
                case BuildingTypeDto.InhibitorBuilding:
                    return "INHIBITOR_BUILDING";
                case BuildingTypeDto.TowerBuilding:
                    return "TOWER_BUILDING";
                default:
                    return string.Empty;
            }
        }
    }
}
