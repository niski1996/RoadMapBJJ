namespace RoadMapBJJ.Contracts.Entities.Learning;

public interface IUsage
{
    public DateOnly Date { get; set; }
    public int RepetitionsCounter { get; set; }
    public string Comments { get; set; }
    
    
    
}