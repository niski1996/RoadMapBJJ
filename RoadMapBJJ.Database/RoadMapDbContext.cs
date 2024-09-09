using Microsoft.EntityFrameworkCore;
using RoadMapBJJ.Contracts.Entities.Persons;
using Microsoft.Extensions.Configuration;

namespace RoadMapBJJ.Database
{
    public class RoadMapDbContext : DbContext
    {

        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Host=127.0.0.1;Port=6432;Database=MainBjj;Username=postgres;Password=yourpassword";
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }
    
}