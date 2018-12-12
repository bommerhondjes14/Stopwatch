using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Type of the ward (Match API).
    /// </summary>
    public enum WardTypeDto
    {
        /// <summary>
        /// Corresponds to green wards.
        /// </summary>
        SightWard,

        /// <summary>
        /// Corresponds to Teemo's mushrooms.
        /// </summary>
        TeemoMushroom,

        /// <summary>
        /// Undefined.
        /// </summary>
        Undefined,

        /// <summary>
        /// Corresponds to pink wards.
        /// </summary>
        VisionWard,

        /// <summary>
        /// Corresponds to warding totems.
        /// </summary>
        YellowTrinket,

        /// <summary>
        /// Corresponds to upgraded warding totems.
        /// </summary>
        YellowTrinketUpgrade,

        /// <summary>
        /// Corresponds to a blue trinket.
        /// </summary>
        BlueTrinket
    }

    static class WardTypeExtension
    {
        public static string ToCustomString(this WardTypeDto wardType)
        {
            switch (wardType)
            {
                case WardTypeDto.SightWard:
                    return "SIGHT_WARD";
                case WardTypeDto.TeemoMushroom:
                    return "TEEMO_MUSHROOM";
                case WardTypeDto.Undefined:
                    return "UNDEFINED";
                case WardTypeDto.VisionWard:
                    return "VISION_WARD";
                case WardTypeDto.YellowTrinket:
                    return "YELLOW_TRINKET";
                case WardTypeDto.YellowTrinketUpgrade:
                    return "YELLOW_TRINKET_UPGRADE";
                case WardTypeDto.BlueTrinket:
                    return "BLUE_TRINKET";
                default:
                    return string.Empty;
            }
        }
    }
}
