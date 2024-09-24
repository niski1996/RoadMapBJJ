using DrillRoad.Contracts.Account;
using DrillRoad.Database;
using DrillRoad.Database.Repositories;
using DrillRoad.Test.Samples;
using Microsoft.EntityFrameworkCore;

namespace SeederDB;

public class Seeder
{
    public Seeder(string ConnectionString)
    {
        var options = new DbContextOptionsBuilder<RoadMapDbContext>()
            .UseNpgsql(ConnectionString)
            .Options;
        context = new RoadMapDbContext(options);
        context.Database.EnsureCreated();
    }
    

    public RoadMapDbContext context { get; set; }

    public void Seed()
    {
        SeedAdditionalUserInfoRow();
    }

    public void SeedAdditionalUserInfoRow()
    {
        var repo =new AdditionalUserRepository(context);
        repo.UpdateAsync(AdditionalUserInfoRowSamples.AdditionalUserInfoRow1Partial(),
            PostmanPreparedUsers.UserFromPostman1);
        context.SaveChanges();
    }

}