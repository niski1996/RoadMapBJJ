namespace DrillRoad.Services.videos;

public class VideoSettings
{
    public int DefaultVideoWidth { get; init; }
    public int DefaultVideoHeight { get; init; }
    public int MaxVideoLenghtInSeconds{ get; init; }
    public int MaxVideoSizeInBytes{ get; init; }
    public int SlidesAmount { get; init; } = 5;
    public required  List<string> AllowedExtensions { get; init; }
    public required string Path {get; init; }
}