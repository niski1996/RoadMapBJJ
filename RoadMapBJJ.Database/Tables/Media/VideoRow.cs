using RoadMapBJJ.Contracts.Common;

namespace RoadMapBJJ.Database.Tables.Media;

internal class VideoRow : IEntity, IDatabaseTable
{
    public Guid Id { get; set; }
    public DateTime InsertTime { get; set; }
}