namespace DrillRoad.Contracts.Account;

public interface IUserPersonalData
{
    
    public string PictureRepoPatch { get; set; }
    public IContact Contact { get; set; }
    public DateTime JoinDate { get; set; }

}