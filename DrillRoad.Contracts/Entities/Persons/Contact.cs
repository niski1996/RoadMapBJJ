using DrillRoad.Contracts.Common;

namespace DrillRoad.Contracts.Entities.Persons;

public class Contact: IEntity
{
    public Address Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Guid Id { get; set; }
}