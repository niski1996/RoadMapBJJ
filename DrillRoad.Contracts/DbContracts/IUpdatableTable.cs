namespace DrillRoad.Contracts.DbContracts;

public interface IUpdatableTable : IDatabaseTable
{
    public DateTime UpdateTime { get; set; }
}