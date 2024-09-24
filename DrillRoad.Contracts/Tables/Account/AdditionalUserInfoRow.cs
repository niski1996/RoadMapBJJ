using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.DbContracts;
using DrillRoad.Contracts.Tables.Media;


namespace DrillRoad.Contracts.Tables.Account;

public class AdditionalUserInfoRow : IDatabaseTable //TODO odwrócić relacje i zahostować to w identity user z kaskada na del
{

    public string PictureRepoPatch { get; set; }
    public ContactRow ContactRow { get; set; }
    public Guid Id { get; set; }
    public DateTime InsertTime { get; set; }
    public List<VideoRow> Videos { get; set; }
    public List<UserDrillIdentity> trainers { get; set; }
}
