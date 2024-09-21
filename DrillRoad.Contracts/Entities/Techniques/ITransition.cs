using DrillRoad.Contracts.Enums;

namespace DrillRoad.Contracts.Entities.Techniques;

public interface ITransition : ITechnique
{
    public IPosition InitialPosition { get; set; }

    public IPosition FinalPosition { get; set; }

    public TransitionType TransitionType { get; set; }
}