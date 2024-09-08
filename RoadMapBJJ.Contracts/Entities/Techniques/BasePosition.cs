using RoadMapBJJ.Contracts.Entities.Media;
using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.Contracts.Entities.Techniques;

public abstract class BasePosition(
    string description,
    string name,
    PositionType positionType) : IPosition
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public PositionType PositionType { get; set; } = positionType;
    
    public IEnumerable<IVideo> TutorialVideos { get; set; } = new List<IVideo>();
    public IEnumerable<IFightAction> PossibleActions { get; set; } = new List<IFightAction>();
    public IEnumerable<ITransition> PossibleTransitions { get; set; } = new List<ITransition>();
    public Guid Id { get; set; } = new Guid();
}