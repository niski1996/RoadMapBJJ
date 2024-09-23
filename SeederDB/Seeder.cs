using DrillRoad.Database;
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

    }

    public RoadMapDbContext context { get; set; }
}