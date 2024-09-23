using Microsoft.AspNetCore.Identity;

namespace DrillRoad.Contracts.Account;

public class DrillIdentityUser : IdentityUser
{
    public Guid? AdditionalUserInfoId { get; set; }
}