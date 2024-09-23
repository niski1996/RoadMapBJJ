using System.Data;

namespace DrillRoad.Database.Tables.Account;

public class ContactRow : IDatabaseTable
{
    
    public AddressRow Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string Email { get; set; }
    public Guid Id { get; set; }
    public DateTime InsertTime { get; set; }
}