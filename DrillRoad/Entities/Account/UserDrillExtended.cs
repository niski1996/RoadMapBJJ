using DrillRoad.Contracts.Account;

namespace DrillRoad.Entities.Account;

public class UserDrillExtended: UserDrillIdentity 
{
    IUserWithPersonalData UserWithPersonalData { get; set; }
}