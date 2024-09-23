using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database.Repositories;

public  class AdditionalUserRepository(RoadMapDbContext context) : IAdditionalUserRepository
{
    public async Task<IEnumerable<DrillIdentityUser>> GetAllUsers()
    {
        return await context.Set<DrillIdentityUser>().AsNoTracking().ToListAsync();
    }

}