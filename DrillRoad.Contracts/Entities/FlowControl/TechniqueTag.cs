using DrillRoad.Contracts.Common;
using DrillRoad.Contracts.Enums;

namespace DrillRoad.Contracts.Entities.FlowControl;

public interface ITechniqueTag : IEntity
{
    public TechniqueTagFamily TechniqueTagFamily { get; set; }
    
    public string Name { get; set; }
}