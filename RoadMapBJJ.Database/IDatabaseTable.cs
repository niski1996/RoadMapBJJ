using RoadMapBJJ.Contracts.Common;

namespace RoadMapBJJ.Database;

internal interface IDatabaseTable : IEntity
{
    public DateTime InsertTime { get; set; }
}