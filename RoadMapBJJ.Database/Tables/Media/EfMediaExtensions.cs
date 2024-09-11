using Microsoft.EntityFrameworkCore;

namespace RoadMapBJJ.Database.Tables.Media;

public static class EfMediaExtensions
{
    public static void AdMedia(this ModelBuilder builder)
    {
        builder.Entity<VideoRow>(e =>
        {
            e.SetBaseGeneratableProperties(); ;
        });
        builder.Entity<VideoDataRow>(e =>
        {
            e.SetUpdatablePropertyGenerate();
            e.SetDescribtionProperties();
        });
        
    }
}