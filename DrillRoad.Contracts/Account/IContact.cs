using DrillRoad.Contracts.Common;

namespace DrillRoad.Contracts.Account;

public interface IContact : IEntity
{
    IAddress Address { get; set; } // Use IAddress for the Address type
    string PhoneNumber { get; set; }
    string Email { get; set; }
}