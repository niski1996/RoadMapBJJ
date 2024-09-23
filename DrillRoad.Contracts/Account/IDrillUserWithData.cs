using DrillRoad.Contracts.Techniques;

namespace DrillRoad.Contracts.Account;

public interface IDrillUserWithData: IPersonalUserData
{
    List<IFightAction> FightActions { get; set; }
    List<IPosition> Positions { get; set; }
    List<ITransition> Transactions { get; set; }
    List<DrillIdentityUser> Trainers { get; set; }
}