using DrillRoad.Contracts.Common;

namespace DrillRoad.Contracts.DbContracts;

public interface IDatabaseTable : IEntity
{
    public DateTime InsertTime { get; set; }
}