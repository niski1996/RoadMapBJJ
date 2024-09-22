using DrillRoad.Database.Tables;
using DrillRoad.Database.Tables.Techniques;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database
{
    public class RoadMapDbContext : IdentityDbContext<IdentityUser>
    {
        public RoadMapDbContext(DbContextOptions<RoadMapDbContext> options) : base(options)
        {

            
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.HasDefaultSchema("main");
            builder.AddTechniques();
            base.OnModelCreating(builder);
        }
    }
}