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
            e.HasMany(u => u.PossibleOpponentActions);
            e.HasMany(u => u.TutorialVideos);
        });
        
        builder.Entity<PositionRow>(e =>
        {
            e.SetTechniqueProperties();
            e.Property(x => x.PositionType).IsRequired();
            e.HasMany(u => u.TutorialVideos);
            e.HasMany(u => u.PossibleActions);
            e.HasMany(u => u.PossibleTransitions);
        });
        
        builder.Entity<TransitionRow>(e =>
        {
            e.SetTechniqueProperties();
            e.Property(x => x.TransitionType).IsRequired();
            e.HasMany(u => u.TutorialVideos);
            e.HasOne(u => u.InitialPosition);
            e.HasOne(u => u.FinalPosition);

        });
    }
}