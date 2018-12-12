using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Lane's type (Match API).
    /// </summary>
    public enum LaneTypeDto
    {
        /// <summary>
        /// Corresponds to the bot lane.
        /// </summary>
        BotLane,

        /// <summary>
        /// Corresponds to the mid lane.
        /// </summary>
        MidLane,

        /// <summary>
        /// Corresponds to the top lane.
        /// </summary>
        TopLane
    }

    static class LaneTypeExtension
    {
        public static string ToCustomString(this LaneTypeDto laneType)
        {
            switch (laneType)
            {
                case LaneTypeDto.BotLane:
                    return "BOT_LANE";
                case LaneTypeDto.MidLane:
                    return "MID_LANE";
                case LaneTypeDto.TopLane:
                    return "TOP_LANE";
                default:
                    return string.Empty;
            }
        }
    }
}
