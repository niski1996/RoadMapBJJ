using DrillRoad.Contracts.Common;
using DrillRoad.Contracts.Enums;

namespace DrillRoad.Entities.Techniques;

public abstract class BaseFightAction : IFightAction
{

    protected BaseFightAction() { }//EF use only
    
    protected BaseFightAction(string description,
        string name,
        ActionType actionType,
        IPosition startingPosition)
    {
        Name = name;
        Description = description;
        ActionType = actionType;
        StartingPosition = startingPosition;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public ActionType ActionType { get; set; }
    public IPosition StartingPosition { get; set; }
    
    public IEnumerable<IVideo> TutorialVideos { get; set; } = new List<IVideo>();
    public IEnumerable<IFightAction> PossibleOpponentActions { get; set; } = new List<IFightAction>();
    public Guid Id { get; set; } = new();
}