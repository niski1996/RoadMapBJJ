using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Enums;

namespace DrillRoad.Entities.Persons;

public class DrillExtendedUser: DrillIdentityUser 
{
    IPersonalUserData PersonalUserData { get; set; }
}