using DrillRoad.Contracts.Common;

namespace DrillRoad.Services.videos;

public interface IVideoService
{
    public Task GenerateSlides(IVideo video);//
    public Task ConvertToMp4(IVideo path);
}

public class VideoService : IVideoService
{
    public Task GenerateSlides(IVideo video)
    {
        throw new NotImplementedException();
    }

    public Task ConvertToMp4(IVideo path)
    {
        throw new NotImplementedException();
    }
}