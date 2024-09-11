using RoadMapBJJ.Contracts.Enums;
using RoadMapBJJ.Database.Tables.Media;

namespace RoadMapBJJ.Database.Tables.Techniques;

internal class PositionRow : IDescriptable, IUpdatableTable
{
    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<VideoRow> TutorialVideos { get; set; }
    public PositionType PositionType { get; set; }
    public IEnumerable<FightActionRow> PossibleActions { get; set; }
    public IEnumerable<TransitionRow> PossibleTransitions { get; set; }

}