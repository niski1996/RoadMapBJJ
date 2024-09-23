using DrillRoad.Contracts.Common;

namespace DrillRoad.Contracts.Techniques;

public interface ITechnique : IEntity
{
    public string Name { get; set; }

    public string Description { get; set; }

    public IEnumerable<IVideo> TutorialVideos { get; set; }
}