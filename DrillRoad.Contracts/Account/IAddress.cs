using DrillRoad.Contracts.Common;

namespace DrillRoad.Contracts.Account;

public interface IAddress : IEntity
{
    string? Apartment { get; set; }
    string Building { get; set; }
    string? Street { get; set; }
    string City { get; set; }
    string PostalCode { get; set; }
    string Country { get; set; }
}