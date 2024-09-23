using DrillRoad.Contracts.Tables.Media;

namespace DrillRoad.Contracts.DbContracts;

public interface ITechniqueDb : IUpdatableTable
{
    public string Name { get; set; }

    public string Description { get; set; }

    public IEnumerable<VideoRow> TutorialVideos { get; set; }
}