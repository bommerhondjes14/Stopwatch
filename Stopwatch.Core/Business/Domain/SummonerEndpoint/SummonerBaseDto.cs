using RiotSharp.Misc;

namespace Stopwatch.Core.Business.Domain
{
    /// <summary>
    /// Class representing the name and id of a Summoner in the API.
    /// </summary>
    public class SummonerBaseDto
    {
        /// <summary>
        /// Defines the Region of a Summoner.
        /// </summary>
        public Region Region { get; set; }

        internal SummonerBaseDto() { }

        internal SummonerBaseDto(string id, string name, Region region)
        {
            Region = region;
            Name = name;
            Id = long.Parse(id);
        }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Account ID
        /// </summary>
        public long AccountId { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        public string Name { get; set; }
    }
}
