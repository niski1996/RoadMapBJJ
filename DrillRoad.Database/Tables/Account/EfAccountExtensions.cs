using DrillRoad.Contracts.Tables.Account;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database.Tables.Account;

public static class EfAccountExtensions
{
    public static void AddAccountInfo(this ModelBuilder builder)
    {
        builder.Entity<AdditionalUserInfoRow>(e =>
        {
            e.SetBaseGeneratableProperties();
            
        });
        
        builder.Entity<AddressRow>(e =>
        {
            e.SetBaseGeneratableProperties();
            e.Property(a => a.Apartment).IsRequired(false);
            e.Property(a => a.Street).IsRequired(false); 
        });
        
        builder.Entity<ContactRow>(e =>
        {
            e.SetBaseGeneratableProperties();
            e.Property(a => a.PhoneNumber).IsRequired(false);
        });
    }
}