using DrillRoad.Contracts.Common;
using DrillRoad.Contracts.Enums;
using DrillRoad.Database.Tables.Media;
using DrillRoad.Entities.Techniques;

namespace DrillRoad.Database.Tables.Techniques;

public class PositionRow : ITechniqueDb
{
    public string Name { get; set; }
    public string Description { get; set; }
    public PositionType PositionType { get; set; }
    
    public IEnumerable<VideoRow> TutorialVideos { get; set; }
    public IEnumerable<FightActionRow> PossibleActions { get; set; }
    public IEnumerable<TransitionRow> PossibleTransitions { get; set; }
    public Guid Id { get; set; } = new Guid();
    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
}