﻿using DrillRoad.Contracts.Enums;
using DrillRoad.Database.Tables.Media;
using DrillRoad.Entities.Techniques;

namespace DrillRoad.Database.Tables.Techniques;

public class TransitionRow : ITechniqueDb
{

    public DateTime InsertTime { get; set; }
    public DateTime UpdateTime { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }


    public IEnumerable<VideoRow> TutorialVideos { get; set; } 
    public PositionRow InitialPosition { get; set; }
    public PositionRow FinalPosition { get; set; }
    public TransitionType TransitionType { get; set; }
    public Guid Id { get; set; } = new();
}