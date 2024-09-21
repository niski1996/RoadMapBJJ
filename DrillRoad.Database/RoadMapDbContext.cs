using DrillRoad.Contracts.Entities.Persons;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database
{
    public class RoadMapDbContext : IdentityDbContext<User>
    {
        public RoadMapDbContext(DbContextOptions options) : base(options)
        {

            
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("main");
        }
    }
}