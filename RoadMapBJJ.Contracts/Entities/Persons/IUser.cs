using RoadMapBJJ.Contracts.Common;

namespace RoadMapBJJ.Contracts.Entities.Persons;

public class Person : IEntity
{
    public Address Address { get; set; }
    public Contact Contact { get; set; }
    public Guid Id { get; set; }
}