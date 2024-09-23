using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Repositories;
using DrillRoad.Database.Tables.Account;
using DrillRoad.Entities.Account;
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

    public Task UpdateAsync(IUserWithFullData user)
    {
        throw new NotImplementedException();
    }

    // Update an existing user with full data
    public async Task UpdateAsync(IUserWithPersonalData user)
    {
        // var identityUser = user as UserDrillIdentity; //TODO brzydkie i niebezpieczne, ale brakuje mi interfejsu
        // var existingUser = await context.Set<UserDrillIdentity>().FirstOrDefaultAsync(x => x.UserName == identityUser.UserName); // Zmiana na async
        //
        // if (existingUser == null)
        // {
        //     // Obsługa przypadku, gdy użytkownik nie istnieje
        //     throw new Exception("User not found");
        // }
    
        var addressRow = new AddressRow
        {
            Apartment = "A1",             // Nullable
            Building = "Building 1",      // Required
            Street = "Main Street",       // Nullable
            City = "Springfield",         // Required
            PostalCode = "12345",         // Required
            Country = "USA",              // Required
            Id = Guid.NewGuid(),          // Generowany GUID
            InsertTime = DateTime.UtcNow  // Data wprowadzenia
        };

        // ContactRow contact = new ContactRow { Address = addressRow, Email = identityUser.UserName };
        // AdditionalUserInfoRow userInfo = new AdditionalUserInfoRow { ContactRow = contact, PictureRepoPatch = "d" };

        // Dodanie informacji użytkownika do kontekstu
        context.Add(addressRow);
    
        // Zapisanie zmian w kontekście
        context.SaveChanges();
    }

}
