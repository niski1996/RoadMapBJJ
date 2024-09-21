using DrillRoad.Contracts.Enums;

namespace DrillRoad.Contracts.Entities.Techniques;

public interface IFightAction : ITechnique
{
    public IPosition StartingPosition { get; set; }
    public ActionType ActionType { get; set; }
    public IEnumerable<IFightAction> PossibleOpponentActions { get; set; }
}