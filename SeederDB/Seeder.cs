using DrillRoad.Database;
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
        // context.Add(AdditionalUserInfoRowSamples.AdditionalUserInfoRow1Partial());
        // context.Add(AdditionalUserInfoRowSamples.AdditionalUserInfoRow2Partial());
        // context.SaveChanges();
        var newUserInfo = AdditionalUserInfoRowSamples.AdditionalUserInfoRow1Partial();

        // Add the new entity to the context
        context.Add(newUserInfo);

        // Save changes to the database
        context.SaveChanges();

        // Return the ID of the newly created record
        Console.WriteLine(newUserInfo.Id);
        
    }

}