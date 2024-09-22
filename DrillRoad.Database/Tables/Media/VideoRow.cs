namespace DrillRoad.Database.Tables.Media;

public class VideoRow : IDatabaseTable
{
    public string VideoRepoPatch { get; set; }
    public Guid Id { get; set; }
    public DateTime InsertTime { get; set; }
}