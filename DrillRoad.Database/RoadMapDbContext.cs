using DrillRoad.Contracts.Entities.Persons;
using DrillRoad.Database.Tables;
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
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("main");
        }
    }
}