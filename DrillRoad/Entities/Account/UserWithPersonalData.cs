using DrillRoad.Contracts.Account;

namespace DrillRoad.Entities.Account;

public class UserWithPersonalData: UserDrillIdentity, IUserWithPersonalData
{
    public string PictureRepoPatch { get; set; }
    public IContact Contact { get; set; }
    public DateTime JoinDate { get; set; }
}