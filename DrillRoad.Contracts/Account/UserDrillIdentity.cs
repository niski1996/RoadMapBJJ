using DrillRoad.Contracts.Tables.Account;
using Microsoft.AspNetCore.Identity;

namespace DrillRoad.Contracts.Account;

public class UserDrillIdentity : IdentityUser
{
    public AdditionalUserInfoRow?  AdditionalUserInfoId { get; set; }
}