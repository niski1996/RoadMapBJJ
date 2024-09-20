using RoadMapBJJ.Contracts.Common;

namespace RoadMapBJJ.Contracts.Entities.Persons;

public class Person : IEntity
{
    public Contact Contact { get; set; }
    public Guid Id { get; set; }
}