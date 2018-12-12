using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Infra.Enums
{
    /// <summary>
    /// Participant's lane (Match API).
    /// </summary>
    public enum LaneDto
    {
        /// <summary>
        /// Corresponds to mid lane.
        /// </summary>
        Mid,

        /// <summary>
        /// Corresponds to mid lane.
        /// </summary>
        Middle,

        /// <summary>
        /// Corresponds to top lane.
        /// </summary>
        Top,

        /// <summary>
        /// Corresponds to jungle.
        /// </summary>
        Jungle,

        /// <summary>
        /// Corresponds to bot lane.
        /// </summary>
        Bot,

        /// <summary>
        /// Corresponds to bot lane.
        /// </summary>
        Bottom,

        /// <summary>
        /// Corresponds to ARAM lane.
        /// </summary>
        None
    }

    static class LaneExtension
    {
        public static string ToCustomString(this LaneDto lane)
        {
            switch (lane)
            {
                case LaneDto.Bot:
                    return "BOT";
                case LaneDto.Bottom:
                    return "BOTTOM";
                case LaneDto.Jungle:
                    return "JUNGLE";
                case LaneDto.Mid:
                    return "MID";
                case LaneDto.Middle:
                    return "MIDDLE";
                case LaneDto.Top:
                    return "TOP";
                case LaneDto.None:
                    return "NONE";
                default:
                    return string.Empty;
            }
        }
    }
}
