using RoadMapBJJ.Contracts.Common;

namespace RoadMapBJJ.Contracts.Entities.Techniques;

public interface ITechnique : IEntity
{
    public string Name { get; set; }

    public string Description { get; set; }

    public IEnumerable<IVideo> TutorialVideos { get; set; }
}