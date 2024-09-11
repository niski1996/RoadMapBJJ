namespace RoadMapBJJ.Database;

internal interface IUpdatableTable : IDatabaseTable
{
    public DateTime UpdateTime { get; set; }
}