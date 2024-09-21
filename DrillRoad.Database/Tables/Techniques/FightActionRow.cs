using DrillRoad.Contracts.Entities.Techniques;
using DrillRoad.Contracts.Enums;

namespace DrillRoad.Database.Tables.Techniques;

public class FightActionRow(string description, string name, ActionType actionType, IPosition startingPosition) : BaseFightAction(description, name, actionType, startingPosition), IUpdatableTable
{
    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
}