using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database.Repositories;

public  class AdditionalUserRepository(RoadMapDbContext context) : IAdditionalUserRepository
{
    public async Task<IEnumerable<UserDrillIdentity>> GetAllUsers()
    {
        return await context.Set<UserDrillIdentity>().AsNoTracking().ToListAsync();
    }

    // Retrieve all users with personal data (assuming there is a table or view)
    public async Task<IEnumerable<IUserWithPersonalData>> GetAllUsersWithPersonalData()
    {
        return await context.Set<IUserWithPersonalData>()
            .AsNoTracking()
            .ToListAsync();
    }

    // Retrieve a single user with full drill data based on their ID
    public async Task<IUserWithFullData?> GetAllDrillUsers(Guid id)
    {
        return default;
        // return await context.Set<IUserWithFullData>()
        //     .AsNoTracking()
        //     .FirstOrDefaultAsync(user => user. == id);
    }

    // Delete a user by their ID
    public async Task DeleteAsync(Guid id)
    {
        var user = await context.Set<UserDrillIdentity>().FindAsync(id);
        if (user != null)
        {
            context.Set<UserDrillIdentity>().Remove(user);
            await context.SaveChangesAsync();
        }
    }

    // Update an existing user with full data
    public async Task UpdateAsync(IUserWithFullData user)
    {
        return;
        // var existingUser = await context.Set<IUserWithFullData>()
        //     .FirstOrDefaultAsync(u => u.Id == user.Id);
        //
        // if (existingUser != null)
        // {
        //     // Assuming EF will track the changes and update the necessary fields
        //     context.Entry(existingUser).CurrentValues.SetValues(user);
        //     await context.SaveChangesAsync();
        // }
    }
}
