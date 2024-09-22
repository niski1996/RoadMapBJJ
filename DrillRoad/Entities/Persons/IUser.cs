using DrillRoad.Contracts.Common;

namespace DrillRoad.Entities.Persons;

public class Person : IEntity
{
    public Contact Contact { get; set; }
    public Guid Id { get; set; }
}