using DrillRoad.Contracts.Account;
using DrillRoad.Database.Tables.Techniques;

namespace DrillRoad.Database.Tables.Account;

public class AdditionalUserInfoRow : IDatabaseTable //TODO odwrócić relacje i zahostować to w identity user z kaskada na del
{

    public string PictureRepoPatch { get; set; }
    public ContactRow ContactRow { get; set; }
    public Guid Id { get; set; }
    public DateTime InsertTime { get; set; }
    public List<FightActionRow> fightActions { get; set; }
    public List<PositionRow> positions { get; set; }
    public List<TransitionRow> transactions { get; set; }
    public List<UserDrillIdentity> trainers { get; set; }
}
