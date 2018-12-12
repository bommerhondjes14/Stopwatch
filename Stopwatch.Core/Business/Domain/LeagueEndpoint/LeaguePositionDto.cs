
namespace Stopwatch.Core.Business.Domain.LeagueEndpoint
{
    /// <summary>
    /// Team or summoner in a league (League API).
    /// </summary>
    public class LeaguePositionDto
    {
        internal LeaguePositionDto()
        {
        }

        /// <summary>
        /// The name of the league of the participant.
        /// Only when it's called from the GetLeaguePositions()
        /// </summary>
        public string LeagueName { get; set; }

        /// <summary>
        /// The queue type of the league.
        /// Only for the GetLeaguePositions() -> don't exist when it's an entry from a League
        /// as there is already the Queue property in this case.
        /// </summary>
        public string QueueType { get; set; }

        /// <summary>
        /// The rank of the participant in a league.
        /// </summary>
        public string Rank { get; set; }

        ///<summary>
        /// The league tier of the participant.
        /// Only when it's called from the GetLeaguePositions()
        /// </summary>
        public string Tier { get; set; }

        /// <summary>
        /// Specifies if the participant is fresh blood.
        /// </summary>
        public bool FreshBlood { get; set; }

        /// <summary>
        /// Specifies if the participant is on a hot streak.
        /// </summary>
        public bool HotStreak { get; set; }

        /// <summary>
        /// Specifies if the participant is inactive.
        /// </summary>
        public bool Inactive { get; set; }

        /// <summary>
        /// Specifies if the participant is a veteran.
        /// </summary>
        public bool Veteran { get; set; }

        /// <summary>
        /// The league points of the participant.
        /// </summary>
        public int LeaguePoints { get; set; }

        /// <summary>
        /// The number of losses for the participant.
        /// </summary>
        public int Losses { get; set; }

        /// <summary>
        /// Mini series data for the participant. Only present if the participant is currently in a mini series.
        /// </summary>
        public MiniSeriesDto MiniSeries { get; set; }

        /// <summary>
        /// The ID of the participant (i.e., summoner or team) represented by this entry.
        /// </summary>
        public string PlayerOrTeamId { get; set; }

        /// <summary>
        /// The name of the the participant (i.e., summoner or team) represented by this entry.
        /// </summary>
        public string PlayerOrTeamName { get; set; }

        /// <summary>
        /// The number of wins for the participant.
        /// </summary>
        public int Wins { get; set; }
    }
}
