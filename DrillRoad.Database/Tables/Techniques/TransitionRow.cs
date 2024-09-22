using DrillRoad.Contracts.Enums;
using DrillRoad.Entities.Techniques;

namespace DrillRoad.Database.Tables.Techniques;

public class TransitionRow : BaseTransition,  IUpdatableTable
{
    public TransitionRow(string description, string name, TransitionType transitionType, PositionRow initialPosition, PositionRow finalPosition) : base(description, name, transitionType, initialPosition, finalPosition)
    {
    }

    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
}