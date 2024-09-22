using DrillRoad.Contracts.Common;

namespace DrillRoad.Database;

public interface IDatabaseTable : IEntity
{
    public DateTime InsertTime { get; set; }
}