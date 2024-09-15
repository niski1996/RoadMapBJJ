using RoadMapBJJ.Contracts.Common;
using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.Contracts.Entities.Techniques;

public abstract class BaseTransition(
    string description,
    string name,
    TransitionType transitionType,
    IPosition initialPosition,
    IPosition finalPosition) : ITransition
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    
    
    public IEnumerable<IVideo> TutorialVideos { get; set; } = new List<IVideo>();
    public IPosition InitialPosition { get; set; } = initialPosition;
    public IPosition FinalPosition { get; set; } = finalPosition;
    public TransitionType TransitionType { get; set; } = transitionType;
    public Guid Id { get; set; } = new();
}