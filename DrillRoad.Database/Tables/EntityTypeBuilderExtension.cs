using DrillRoad.Contracts.Common;
using DrillRoad.Contracts.DbContracts;
using DrillRoad.Entities.Techniques;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrillRoad.Database.Tables;

internal static class EntityTypeBuilderExtension
{
    internal static void SetUpdatablePropertyGenerate<T>(this EntityTypeBuilder<T> entry) where T : class, IUpdatableTable
    {
        entry.SetBaseGeneratableProperties();
        entry.Property(t => t.UpdateTime)
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAddOrUpdate();
    }

    internal static void SetBaseGeneratableProperties<T>(this EntityTypeBuilder<T> entry) where T : class, IDatabaseTable, IEntity
    {
        entry.Property(t => t.InsertTime)
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAdd();
        entry.HasKey(t => t.Id);
        entry.Property(t => t.Id)
            .ValueGeneratedOnAdd();
    }
    
    internal static void SetTechniqueProperties<T>(this EntityTypeBuilder<T> entry) where T : class, ITechniqueDb, IUpdatableTable
    {
        entry.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(200);
        entry.Property(t => t.Description).IsRequired(false);
    }
    
    
}