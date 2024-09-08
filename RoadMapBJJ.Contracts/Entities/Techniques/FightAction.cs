using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.Contracts.Entities.Techniques;

public class FightAction(string description, string name, ActionType actionType, IPosition startingPosition) : BaseFightAction(description, name, actionType, startingPosition)
{
}