using DrillRoad.Contracts.DbContracts;

namespace DrillRoad.Contracts.Tables.Media;

public class VideoInfoRow : IUpdatableTable
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
}