using Stopwatch.Core.Infra.Enums.MatchEndpointEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Core.Business.Domain.MatchEndpoint
{
    public class EventDto
    {
        internal EventDto() { }

        /// <summary>
        /// The ascended type of the event. Only present if relevant.
        /// Note that CLEAR_ASCENDED refers to when a participants kills the ascended player.
        /// </summary>
        public AscendedTypeDto AscendedType { get; set; }

        /// <summary>
        /// The assisting participant IDs of the event. Only present if relevant.
        /// </summary>
        public List<int> AssistingParticipantIds { get; set; }

        /// <summary>
        /// The building type of the event (tower or inhibitor). Only present if relevant.
        /// </summary>
        public BuildingTypeDto? BuildingType { get; set; }

        /// <summary>
        /// The creator ID of the event. Only present if relevant.
        /// </summary>
        public int CreatorId { get; set; }

        /// <summary>
        /// Event type (building kills, champion kills, ward placements, items purchases, etc).
        /// </summary>
        public EventTypeDto? EventType { get; set; }

        /// <summary>
        /// The ending item ID of the event. Only present if relevant.
        /// </summary>
        public int ItemAfter { get; set; }

        /// <summary>
        /// The starting item ID of the event. Only present if relevant.
        /// </summary>
        public int ItemBefore { get; set; }

        /// <summary>
        /// The item ID of the event. Only present if relevant.
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// The killer ID of the event. Only present if relevant.
        /// </summary>
        public int KillerId { get; set; }

        /// <summary>
        /// The lane type of the event. Only present if relevant.
        /// </summary>
        public LaneTypeDto? LaneType { get; set; }

        /// <summary>
        /// The level up type of the event. Only present if relevant.
        /// </summary>
        public LevelUpTypeDto? LevelUpType { get; set; }

        /// <summary>
        /// The monster type of the event. Only present if relevant.
        /// </summary>
        public MonsterTypeDto? MonsterType { get; set; }

        /// <summary>
        /// The monster type of the event. Only present if relevant.
        /// </summary>
        public MonsterSubTypeDto? MonsterSubType { get; set; }

        /// <summary>
        /// The participant ID of the event. Only present if relevant.
        /// </summary>
        public int ParticipantId { get; set; }

        /// <summary>
        /// The point captured in the event. Only present if relevant.
        /// </summary>
        public CapturedPointDto? CapturedPoint { get; set; }

        /// <summary>
        /// The position of the event. Only present if relevant.
        /// </summary>
        public PositionDto Position { get; set; }

        /// <summary>
        /// The skill slot of the event. Only present if relevant.
        /// </summary>
        public int SkillSlot { get; set; }

        /// <summary>
        /// The team ID of the event. Only present if relevant.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// Represents how much time into the game the event occurred.
        /// </summary>
        public TimeSpan Timestamp { get; set; }

        /// <summary>
        /// The tower type of the event. Only present if relevant.
        /// </summary>
        public TowerTypeDto? TowerType { get; set; }

        /// <summary>
        /// The victim ID of the event. Only present if relevant.
        /// </summary>
        public int VictimId { get; set; }

        /// <summary>
        /// The ward type of the event. Only present if relevant.
        /// </summary>
        public WardTypeDto? WardType { get; set; }
    }
}
