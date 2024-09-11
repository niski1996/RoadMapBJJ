using RoadMapBJJ.Contracts.Entities.Media;
using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.Contracts.Entities.Techniques;

public abstract class BaseTransition : ITransition
{
    public BaseTransition() //EF use only
    {
    }

    protected BaseTransition(string description,
        string name,
        TransitionType transitionType,
        IPosition initialPosition,
        IPosition finalPosition)
    {
        Name = name;
        Description = description;
        InitialPosition = initialPosition;
        FinalPosition = finalPosition;
        TransitionType = transitionType;
    }

    public string Name { get; set; }
    public string Description { get; set; }


    public IEnumerable<IVideo> TutorialVideos { get; set; } = new List<IVideo>();
    public IPosition InitialPosition { get; set; }
    public IPosition FinalPosition { get; set; }
    public TransitionType TransitionType { get; set; }
    public Guid Id { get; set; } = new();
}