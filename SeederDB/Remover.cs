using DrillRoad.Contracts.Tables.Account;
using DrillRoad.Database;
using Microsoft.EntityFrameworkCore;

namespace SeederDB;

public class Remover
{
    public Remover(string ConnectionString)
    {
        var options = new DbContextOptionsBuilder<RoadMapDbContext>()
            .UseNpgsql(ConnectionString)
            .Options;
        context = new RoadMapDbContext(options);
        context.Database.EnsureCreated();
    }
    

    public RoadMapDbContext context { get; set; }

    public void Remove()
    {
        RemoveAdditionalInfo();
    }

    public void RemoveAdditionalInfo()
    {
        Remove<AddressRow>();
        Remove<ContactRow>();
        Remove<AdditionalUserInfoRow>();
    }
    public void Remove<T>() where T : class
    {
        var dbSet = context.Set<T>();
        if (dbSet != null)
        {
            // Fetch all entities in the specified table
            var entities = dbSet.ToList();
            // Remove all entities
            dbSet.RemoveRange(entities);
            // Save changes to the database
            context.SaveChanges();
        }
        else
        {
            throw new InvalidOperationException($"The specified entity type {typeof(T).Name} does not exist in the context.");
        }
    }
}