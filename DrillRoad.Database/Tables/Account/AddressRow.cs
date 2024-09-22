using System.Data;

namespace DrillRoad.Database.Tables.Account;

public class AddressRow : IDatabaseTable
{

    public string? Apartment { get; set; }
    public required string Building { get; set; }
    public string? Street { get; set; }
    public required string City { get; set; }
    public required string PostalCode { get; set; }
    public required string Country { get; set; }
    public Guid Id { get; set; } = new Guid();

    public DateTime InsertTime { get; set; }
}