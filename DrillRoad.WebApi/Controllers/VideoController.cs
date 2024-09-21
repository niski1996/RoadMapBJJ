using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DrillRoad.WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class VideoController : ControllerBase
{
    [HttpPost]
    public Task UploadVideo(IFormFile file)
    {
        return Task.CompletedTask;
    }

    [HttpGet, Authorize]
    public string GetVideos()
    {
        return "Videos";
    }
}