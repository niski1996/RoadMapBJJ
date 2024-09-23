using Microsoft.AspNetCore.Identity;

namespace DrillRoad.Contracts.Account;

public class UserDrillIdentity : IdentityUser
{
    public Guid? AdditionalUserInfoId { get; set; }
}