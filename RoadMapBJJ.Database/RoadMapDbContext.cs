using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoadMapBJJ.Contracts.Entities.Persons;
using RoadMapBJJ.Database.Tables.Media;
using RoadMapBJJ.Database.Tables.Techniques;

namespace RoadMapBJJ.Database
{
    public class RoadMapDbContext : IdentityDbContext<User>
    {
        public RoadMapDbContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.AddTechniques();
            builder.AdMedia();
            builder.HasDefaultSchema("main");
        }
    }
}