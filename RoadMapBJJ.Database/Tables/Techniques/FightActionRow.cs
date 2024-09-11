using RoadMapBJJ.Contracts.Enums;
using RoadMapBJJ.Database.Tables.Media;

namespace RoadMapBJJ.Database.Tables.Techniques;

internal class FightActionRow :IDescriptable, IUpdatableTable
{

    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<VideoRow> TutorialVideos { get; set; }
    public PositionRow StartingPosition { get; set; }
    public ActionType ActionType { get; set; }
    public IEnumerable<FightActionRow> PossibleOpponentActions { get; set; }
}