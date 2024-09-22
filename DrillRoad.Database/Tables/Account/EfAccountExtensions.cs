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
        });
        
        builder.Entity<ContactRow>(e =>
        {
            e.SetBaseGeneratableProperties();
        });
    }
}