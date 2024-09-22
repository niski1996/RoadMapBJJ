using DrillRoad.Contracts.Common;
using DrillRoad.Database.Tables.Media;

namespace DrillRoad.Database;

public interface ITechniqueDb : IUpdatableTable
{
    public string Name { get; set; }

    public string Description { get; set; }

    public IEnumerable<VideoRow> TutorialVideos { get; set; }
}