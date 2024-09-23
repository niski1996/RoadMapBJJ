using DrillRoad.Contracts.Account;

namespace DrillRoad.Contracts.Repositories;

public interface IAdditionalUserRepository
{
    Task<IEnumerable<UserDrillIdentity>> GetAllUsers();
    Task<IEnumerable<IUserWithPersonalData>> GetAllUsersWithPersonalData();
    Task<IUserWithFullData> GetAllDrillUsers(Guid id);
    Task DeleteAsync(Guid id);
    Task UpdateAsync(IUserWithFullData user);
}