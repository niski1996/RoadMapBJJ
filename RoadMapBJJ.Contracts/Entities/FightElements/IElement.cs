using RoadMapBJJ.Contracts.Common;
using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.Contracts.Entities.FightElements;

public interface IElement : IEntity
{
    public IEnumerable<IElement> PrecedingElements { get; set; }
    IEnumerable<IElement> FollowingElements { get; set; }
    public string Description { get; set; }
    IEnumerable<object> TutorialVideos { get; set; }
}

public interface IAction : IElement
{
    public ActionType ActionType { get; set; }
    public IEnumerable<IAction> PossibleOpponentActions { get; set; }
}

public interface IPosition : IElement
{
    public PositionType PositionType { get; set; }
    public IEnumerable<IAction> PossibleActions { get; set; }
    public IEnumerable<ITransition> PossibleTransitions { get; set; }
}

public interface ITransition : IElement
{
    public IPosition InitialPosition { get; set; }

    public IPosition FinalPosition { get; set; }

    public TransitionType TransitionType { get; set; }
}