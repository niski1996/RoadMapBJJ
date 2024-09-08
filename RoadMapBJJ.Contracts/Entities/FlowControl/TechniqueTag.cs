using RoadMapBJJ.Contracts.Common;
using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.Contracts.Entities.FlowControl;

public interface ITechniqueTag : IEntity
{
    public TechniqueTagFamily TechniqueTagFamily { get; set; }
    
    public string Name { get; set; }
}