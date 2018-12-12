using RiotSharp.Endpoints.MatchEndpoint.Enums.Converters;

namespace Stopwatch.Core.Infra.Enums.MatchEndpointEnums
{
    /// <summary>
    /// Event's type (Match API).
    /// </summary>
    public enum EventTypeDto
    {
        /// <summary>
        /// Ascended event.
        /// </summary>
        AscendedEvent,

        /// <summary>
        /// Triggers on building kills.
        /// </summary>
        BuildingKill,

        /// <summary>
        /// Triggers on captured point in dominion games.
        /// </summary>
        CapturePoint,

        /// <summary>
        /// Triggers on champion kills.
        /// </summary>
        ChampionKill,

        /// <summary>
        /// Triggers on Nashor or Dragon kills.
        /// </summary>
        EliteMonsterKill,

        /// <summary>
        /// Triggers on item destructions.
        /// </summary>
        ItemDestroyed,

        /// <summary>
        /// Triggers on item purchases.
        /// </summary>
        ItemPurchased,

        /// <summary>
        /// Triggers on item sells.
        /// </summary>
        ItemSold,

        /// <summary>
        /// Triggers on undo item purchases.
        /// </summary>
        ItemUndo,

        /// <summary>
        /// Triggers on skill level ups.
        /// </summary>
        SkillLevelUp,

        /// <summary>
        /// Triggers on ward kills.
        /// </summary>
        WardKill,

        /// <summary>
        /// Triggers on ward placements.
        /// </summary>
        WardPlaced
    }

    static class EventTypeExtension
    {
        public static string ToCustomString(this EventTypeDto eventType)
        {
            switch (eventType)
            {
                case EventTypeDto.AscendedEvent:
                    return "ASCENDED_EVENT";
                case EventTypeDto.BuildingKill:
                    return "BUILDING_KILL";
                case EventTypeDto.CapturePoint:
                    return "CAPTURE_POINT";
                case EventTypeDto.ChampionKill:
                    return "CHAMPION_KILL";
                case EventTypeDto.EliteMonsterKill:
                    return "ELITE_MONSTER_KILL";
                case EventTypeDto.ItemDestroyed:
                    return "ITEM_DESTROYED";
                case EventTypeDto.ItemPurchased:
                    return "ITEM_PURCHASED";
                case EventTypeDto.ItemSold:
                    return "ITEM_SOLD";
                case EventTypeDto.ItemUndo:
                    return "ITEM_UNDO";
                case EventTypeDto.SkillLevelUp:
                    return "SKILL_LEVEL_UP";
                case EventTypeDto.WardKill:
                    return "WARD_KILL";
                case EventTypeDto.WardPlaced:
                    return "WARD_PLACED";
                default:
                    return string.Empty;
            }
        }
    }
}
