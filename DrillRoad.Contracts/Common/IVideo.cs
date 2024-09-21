using Microsoft.AspNetCore.Http;

namespace DrillRoad.Contracts.Common;

public interface IVideo : IEntity
{
    public string patch { get; set; }
    
    public IFormFile File { get; set; } 
}