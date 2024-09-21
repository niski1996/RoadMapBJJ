using DrillRoad.Contracts.Entities.Techniques;
using DrillRoad.Contracts.Enums;

namespace DrillRoad.Database.Tables.Techniques;

public class TransitionRow(string description, string name, TransitionType transitionType, IPosition initialPosition, IPosition finalPosition) : BaseTransition(description, name, transitionType, initialPosition, finalPosition), IDatabaseTable, IUpdatableTable
{
    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
}