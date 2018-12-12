using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Class representing a capture point in a dominion game (Match API).
    /// </summary>
    public enum CapturedPointDto
    {
        /// <summary>
        /// Point A.
        /// </summary>
        PointA,

        /// <summary>
        /// Point B.
        /// </summary>
        PointB,

        /// <summary>
        /// Point C.
        /// </summary>
        PointC,

        /// <summary>
        /// Point D.
        /// </summary>
        PointD,

        /// <summary>
        /// Point E.
        /// </summary>
        PointE
    }

    static class CapturedPointExtension
    {
        public static string ToCustomString(this CapturedPointDto capturePoint)
        {
            switch (capturePoint)
            {
                case CapturedPointDto.PointA:
                    return "POINT_A";
                case CapturedPointDto.PointB:
                    return "POINT_B";
                case CapturedPointDto.PointC:
                    return "POINT_C";
                case CapturedPointDto.PointD:
                    return "POINT_D";
                case CapturedPointDto.PointE:
                    return "POINT_E";
                default:
                    return string.Empty;
            }
        }
    }
}
