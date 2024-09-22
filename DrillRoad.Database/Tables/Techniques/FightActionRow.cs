using DrillRoad.Contracts.Enums;
using DrillRoad.Database.Tables.Media;
using DrillRoad.Entities.Techniques;

namespace DrillRoad.Database.Tables.Techniques;

public class FightActionRow : ITechniqueDb
{
    
    public string Name { get; set; }
    public string Description { get; set; }
    public ActionType ActionType { get; set; }
    public PositionRow StartingPosition { get; set; }
    
    public IEnumerable<VideoRow> TutorialVideos { get; set; } 
    public IEnumerable<FightActionRow> PossibleOpponentActions { get; set; } 
    public Guid Id { get; set; } = new();
    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
