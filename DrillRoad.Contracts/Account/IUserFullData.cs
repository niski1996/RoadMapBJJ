using DrillRoad.Contracts.Techniques;

namespace DrillRoad.Contracts.Account;

public interface IUserFullData: IUserPersonalData
{
    List<IFightAction> FightActions { get; set; }
    List<IPosition> Positions { get; set; }
    List<ITransition> Transactions { get; set; }
    List<UserDrillIdentity> Trainers { get; set; }
}