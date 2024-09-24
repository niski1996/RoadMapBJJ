using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Tables.Account;
using DrillRoad.Database.Tables;
using DrillRoad.Database.Tables.Account;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database;

public class RoadMapDbContext : IdentityDbContext<UserDrillIdentity>
{
    public RoadMapDbContext(DbContextOptions<RoadMapDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("main");
        //TODO builder.AddTechniques(); 
        builder.AddAccountInfo();
        base.OnModelCreating(builder);
    }
}