using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DrillRoad.Database;

public static class MigrationExtension
{
    public static void ApplyMigration(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<RoadMapDbContext>();
        context.Database.Migrate();
    }
}