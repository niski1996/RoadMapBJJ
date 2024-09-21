using DrillRoad.Contracts.Entities.Techniques;
using DrillRoad.Contracts.Enums;

namespace DrillRoad.Database.Tables.Techniques;

public class PositionRow(string description, string name, PositionType positionType) : BasePosition(description, name, positionType), IDatabaseTable, IUpdatableTable
{
    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
}