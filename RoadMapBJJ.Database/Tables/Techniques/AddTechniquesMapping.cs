using Microsoft.EntityFrameworkCore;

namespace RoadMapBJJ.Database.Tables.Techniques;

public static class EfTechniquesExtensions
{
    public static void AddTechniques(this ModelBuilder builder)
    {
        builder.Entity<FightActionRow>(e =>
        {
            e.SetTechniqueProperties();
            e.Property(x => x.ActionType).IsRequired();
        });
        
        builder.Entity<PositionRow>(e =>
        {
            e.SetTechniqueProperties();
            e.Property(x => x.PositionType).IsRequired();
        });
        
        builder.Entity<TransitionRow>(e =>
        {
            e.SetTechniqueProperties();
            e.Property(x => x.TransitionType).IsRequired();
            
        });
    }
}