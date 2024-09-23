using DrillRoad.Contracts.Account;

namespace DrillRoad.Contracts.Repositories;

public interface IAdditionalUserRepository
{
    Task<IEnumerable<DrillIdentityUser>> GetAllUsers();

}