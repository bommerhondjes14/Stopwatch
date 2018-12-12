using RiotSharp.Endpoints.LeagueEndpoint.Enums.Converters;

namespace Stopwatch.Core.Business.Domain.LeagueEndpoint
{
    /// <summary>
    /// LeaguePosition has entered a MiniSeries (League API).
    /// </summary>
    public class MiniSeriesDto
    {
        internal MiniSeriesDto() { }

        /// <summary>
        /// Number of current losses in the mini series.
        /// </summary>
        public int Losses { get; set; }

        /// <summary>
        /// String showing the current, sequential mini series progress where 'W' represents a win, 'L' represents a
        /// loss, and 'N' represents a game that hasn't been played yet.
        /// </summary>
        public char[] Progress { get; set; }

        /// <summary>
        /// Number of wins required for promotion.
        /// </summary>
        public int Target { get; set; }

        /// <summary>
        /// Number of current wins in the mini series.
        /// </summary>
        public int Wins { get; set; }
    }
}
