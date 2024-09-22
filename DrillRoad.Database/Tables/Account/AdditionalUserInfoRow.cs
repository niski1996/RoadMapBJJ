namespace DrillRoad.Database.Tables.Account;

public class AdditionalUserInfoRow : IDatabaseTable
{
    public Guid UserId  { get; set; }
    public string PictureRepoPatch { get; set; }
    public ContactRow ContactRow { get; set; }
    public Guid Id { get; set; }
    public DateTime InsertTime { get; set; }
}