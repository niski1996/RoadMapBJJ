using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoadMapBJJ.Contracts.Common;

namespace RoadMapBJJ.Database.Tables;

internal static class EntityTypeBuilderExtension
{

    internal static void SetBaseGeneratableProperties<T>(this EntityTypeBuilder<T> entry) where T : class, IDatabaseTable, IEntity
    {
        entry.Property(t => t.InsertTime)
            .HasDefaultValueSql("GETUTCDATE()")
            .ValueGeneratedOnAdd();
        entry.HasKey(t => t.Id);
        entry.Property(t => t.Id)
            .ValueGeneratedOnAdd();
    }
    
    internal static void SetUpdatablePropertyGenerate<T>(this EntityTypeBuilder<T> entry) where T : class, IUpdatableTable
    {
        entry.SetBaseGeneratableProperties();
        entry.Property(t => t.UpdateTime)
            .HasDefaultValueSql("GETUTCDATE()")
            .ValueGeneratedOnAddOrUpdate();
    }
    
    internal static void SetDescribtionProperties<T>(this EntityTypeBuilder<T> entry) where T : class, IDescriptable, IUpdatableTable
    {
        entry.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(200);
        entry.Property(t => t.Description).IsRequired(false);
    }
    
    internal static void SetTechniqueProperties<T>(this EntityTypeBuilder<T> entry) where T : class, IDescriptable, IUpdatableTable
    {
        entry.SetUpdatablePropertyGenerate();
        entry.SetDescribtionProperties();
    }
    
    
}

internal interface IDescriptable
{
    public string Name { get; set; }

    public string Description { get; set; }
}