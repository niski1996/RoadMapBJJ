using Microsoft.AspNetCore.Http;

namespace RoadMapBJJ.Contracts.Common;

public interface IVideo : IEntity
{
    public string patch { get; set; }
    
    public IFormFile File { get; set; } 
}