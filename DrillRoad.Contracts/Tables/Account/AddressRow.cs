using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.DbContracts;

namespace DrillRoad.Contracts.Tables.Account;

public class AddressRow : IDatabaseTable, IAddress 
{

    public string? Apartment { get; set; }
    public required string Building { get; set; }
    public string? Street { get; set; }
    public required string City { get; set; }
    public required string PostalCode { get; set; }
    public required string Country { get; set; }
    public Guid Id { get; set; } = new();

    public DateTime InsertTime { get; set; }
}