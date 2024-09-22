using DrillRoad.Contracts.Common;
using DrillRoad.Contracts.Enums;

namespace DrillRoad.Entities.Techniques;

public abstract class BasePosition : IPosition
{
    public BasePosition() //EF use only
    {
    }
    protected BasePosition(string description,
        string name,
        PositionType positionType)
    {
        Name = name;
        Description = description;
        PositionType = positionType;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public PositionType PositionType { get; set; }
    
    public IEnumerable<IVideo> TutorialVideos { get; set; } = new List<IVideo>();
    public IEnumerable<IFightAction> PossibleActions { get; set; } = new List<IFightAction>();
    public IEnumerable<ITransition> PossibleTransitions { get; set; } = new List<ITransition>();
    public Guid Id { get; set; } = new Guid();
}