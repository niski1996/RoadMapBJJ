using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Techniques;

namespace DrillRoad.Entities.Account;

public class UserWithFullData: IUserWithFullData
{
    public string PictureRepoPatch { get; set; }
    public IContact Contact { get; set; }
    public DateTime JoinDate { get; set; }
    public List<IFightAction> FightActions { get; set; }
    public List<IPosition> Positions { get; set; }
    public List<ITransition> Transactions { get; set; }
    public List<UserDrillIdentity> Trainers { get; set; }
}