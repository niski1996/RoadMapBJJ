using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.Contracts.Entities.Techniques;

public interface IPosition : ITechnique
{
    public PositionType PositionType { get; set; }
    public IEnumerable<IFightAction> PossibleActions { get; set; }
    public IEnumerable<ITransition> PossibleTransitions { get; set; }
}