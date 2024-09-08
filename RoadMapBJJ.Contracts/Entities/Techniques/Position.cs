using RoadMapBJJ.Contracts.Entities.Learning;
using RoadMapBJJ.Contracts.Enums;

namespace RoadMapBJJ.Contracts.Entities.Techniques;

public class Position(string description, string name, PositionType positionType) : BasePosition(description, name, positionType)
{
}

public class UserPosition : BasePosition, ILearningInfo
{
    public UserPosition(string description, string name, PositionType positionType) : base(description, name, positionType)
    {
    }

    public IEnumerable<IUsage> Usages { get; set; } = new List<IUsage>();
    
    
    public IUsage? GetLastUsage() => Usages.MaxBy(x => x.Date);
    

    public int GetAllUsages() => Usages.Sum(x => x.RepetitionsCounter);
    
}
