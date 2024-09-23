namespace DrillRoad.Contracts.Account;

public interface IPersonalUserData
{
    
    public string PictureRepoPatch { get; set; }
    public IContact Contact { get; set; }
    public DateTime JoinDate { get; set; }

}