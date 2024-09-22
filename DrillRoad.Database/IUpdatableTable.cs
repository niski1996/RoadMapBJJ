namespace DrillRoad.Database;

public interface IUpdatableTable : IDatabaseTable
{
    public DateTime UpdateTime { get; set; }
}