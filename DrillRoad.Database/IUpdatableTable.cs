namespace DrillRoad.Database;

internal interface IUpdatableTable : IDatabaseTable
{
    public DateTime UpdateTime { get; set; }
}