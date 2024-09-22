using DrillRoad.Contracts.Enums;
using DrillRoad.Entities.Techniques;

namespace DrillRoad.Database.Tables.Techniques;

public class FightActionRow(string description, string name, ActionType actionType, PositionRow startingPosition) : BaseFightAction(description, name, actionType, startingPosition), IUpdatableTable
{
    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
}