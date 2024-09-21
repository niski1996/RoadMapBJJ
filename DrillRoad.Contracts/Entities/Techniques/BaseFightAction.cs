using DrillRoad.Contracts.Common;
using DrillRoad.Contracts.Enums;

namespace DrillRoad.Contracts.Entities.Techniques;

public abstract class BaseFightAction(
    string description,
    string name,
    ActionType actionType,
    IPosition startingPosition) : IFightAction
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public ActionType ActionType { get; set; } = actionType;
    public IPosition StartingPosition { get; set; } = startingPosition;
    
    public IEnumerable<IVideo> TutorialVideos { get; set; } = new List<IVideo>();
    public IEnumerable<IFightAction> PossibleOpponentActions { get; set; } = new List<IFightAction>();
    public Guid Id { get; set; } = new();
}