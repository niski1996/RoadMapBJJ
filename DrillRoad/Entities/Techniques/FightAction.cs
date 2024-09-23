using DrillRoad.Contracts.Enums;
using DrillRoad.Contracts.Techniques;

namespace DrillRoad.Entities.Techniques;

public class FightAction(string description, string name, ActionType actionType, IPosition startingPosition) : BaseFightAction(description, name, actionType, startingPosition)
{
}