using DrillRoad.Contracts.Account;
using DrillRoad.Database.Tables.Techniques;

namespace DrillRoad.Database.Tables.Account;

public class AdditionalUserInfoRow : IDatabaseTable //TODO odwrócić relacje i zahostować to w identity user z kaskada na del
{

    public string PictureRepoPatch { get; set; }
    public ContactRow ContactRow { get; set; }
    public Guid Id { get; set; }
    public DateTime InsertTime { get; set; }
    List<FightActionRow> fightActions { get; set; }
    List<PositionRow> positions { get; set; }
    List<TransitionRow> transactions { get; set; }
    List<DrillIdentityUser> trainers { get; set; }
}
public class AdditionalUserInfo : IDatabaseTable //TODO odwrócić relacje i zahostować to w identity user z kaskada na del
{

    public string PictureRepoPatch { get; set; }
    public ContactRow ContactRow { get; set; }
    public Guid Id { get; set; }
    public DateTime InsertTime { get; set; }
    List<FightActionRow> fightActions { get; set; }
    List<PositionRow> positions { get; set; }
    List<TransitionRow> transactions { get; set; }
    List<DrillIdentityUser> trainers { get; set; }
}