using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoadMapBJJ.Contracts.Entities.Persons;
using Microsoft.Extensions.Configuration;
using RoadMapBJJ.Database.Tables.Techniques;

namespace RoadMapBJJ.Database
{
    public class RoadMapDbContext : IdentityDbContext<User>
    {
        public RoadMapDbContext(DbContextOptions options) : base(options)
        {
  
              
        }

        public DbSet<Person> Personseating(ModelBuilder builder)
        {
            return Set<Person>();
        }
        
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("main");
        }
    }
}