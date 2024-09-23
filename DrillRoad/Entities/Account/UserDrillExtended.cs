using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Enums;

namespace DrillRoad.Entities.Persons;

public class UserDrillExtended: UserDrillIdentity 
{
    IUserWithPersonalData UserWithPersonalData { get; set; }
}