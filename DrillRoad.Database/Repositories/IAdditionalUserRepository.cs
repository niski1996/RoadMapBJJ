using DrillRoad.Contracts.Account;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database.Repositories;

public interface IAdditionalUserRepository
{
    Task<IEnumerable<DrillIdentityUser>> GetAllUsers();

}

public  class AdditionalUserRepository(RoadMapDbContext context)
{
    public async Task<List<DrillIdentityUser>> GetAllUsers()
    {
        return await context.Set<DrillIdentityUser>().AsNoTracking().ToListAsync();
    }

}