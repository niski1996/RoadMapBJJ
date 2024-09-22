namespace DrillRoad.Entities.Learning;

public interface ILearningInfo
{
    public IEnumerable<IUsage> Usages { get; set; }
    public IUsage? GetLastUsage();
    public int GetAllUsages();
}   