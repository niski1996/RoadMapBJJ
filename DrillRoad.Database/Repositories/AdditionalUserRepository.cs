using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Repositories;
using DrillRoad.Contracts.Tables.Account;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database.Repositories;

public  class AdditionalUserRepository(RoadMapDbContext context) : IAdditionalUserRepository
{
    
    public async Task<IEnumerable<UserDrillIdentity>> GetAllUsers()
    {
        return await context.Set<UserDrillIdentity>().ToListAsync();
    }

    public async Task<IEnumerable<UserDrillIdentity>> GetAllUsersWithPersonalData()
    {

        return await context.Set<UserDrillIdentity>()
            .Include(u => u.AdditionalUserInfo)
            .ToListAsync();
    }

    public async Task<UserDrillIdentity?> GetUserWithPersonalData(string username)
    {
        return await context.Set<UserDrillIdentity>()
            .Include(u => u.AdditionalUserInfo)
            .FirstOrDefaultAsync(u => u.UserName == username);
    }

    public async Task<UserDrillIdentity?> GetUserDetails(string username)
    {
        return await context.Set<UserDrillIdentity>()
            .Include(u => u.AdditionalUserInfo)
                .ThenInclude(z=>z.ContactRow).ThenInclude(w=>w.Address)
            .FirstOrDefaultAsync(u => u.UserName == username);
    }

    public async Task DeleteAsync(string username)
    {
        var user = await context.Set<UserDrillIdentity>()
            .Include(u => u.AdditionalUserInfo)
            .FirstOrDefaultAsync(u => u.UserName == username);
        if (user != null)
        {
            context.Set<UserDrillIdentity>().Remove(user);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateAsync(AdditionalUserInfoRow additionalInfo, string username)
    {
        var user = context.Set<UserDrillIdentity>()
            .Include(u => u.AdditionalUserInfo)
            .ThenInclude(z=>z.ContactRow).ThenInclude(w=>w.Address)
            .FirstOrDefault(u => u.UserName == username);
        context.Add(additionalInfo);
        user.AdditionalUserInfo = additionalInfo;
        context.Update(user);

        context.SaveChanges();
    }

}
