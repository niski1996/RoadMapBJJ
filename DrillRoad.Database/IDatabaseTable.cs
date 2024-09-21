using DrillRoad.Contracts.Common;

namespace DrillRoad.Database;

internal interface IDatabaseTable : IEntity
{
    public DateTime InsertTime { get; set; }
}