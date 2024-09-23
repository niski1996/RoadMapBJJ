using DrillRoad.Contracts.Account;

namespace DrillRoad.Entities.Account;

public class Contact: IContact
{
    public IAddress Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Guid Id { get; set; }
}
