using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Tables.Account;

namespace DrillRoad.Contracts.Repositories;

public interface IAdditionalUserRepository
{
    Task<IEnumerable<UserDrillIdentity>> GetAllUsers();
    Task<IEnumerable<UserDrillIdentity>> GetAllUsersWithPersonalData();
    Task<UserDrillIdentity?> GetUserWithPersonalData(string username);
    Task<UserDrillIdentity?> GetUserDetails(string username);
    Task DeleteAsync(string username);
    Task UpdateAsync(AdditionalUserInfoRow info, string username);
}