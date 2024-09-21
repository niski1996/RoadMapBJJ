namespace RoadMapBJJ.Database.Tables.Media;

internal class VideoDataRow : IUpdatableTable, IDescriptable
{
    public Guid Id { get; set; }
    public VideoRow VideoRow { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
}