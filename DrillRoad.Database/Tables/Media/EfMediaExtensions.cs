using DrillRoad.Contracts.Tables.Media;
using Microsoft.EntityFrameworkCore;

namespace DrillRoad.Database.Tables.Media;

public static class EfMediaExtensions
{
    public static void AddMedia(this ModelBuilder builder)
    {
        builder.Entity<VideoRow>(e =>
        {
            e.SetBaseGeneratableProperties();
        });
        builder.Entity<VideoInfoRow>(e => e.SetUpdatablePropertyGenerate());
    }
}