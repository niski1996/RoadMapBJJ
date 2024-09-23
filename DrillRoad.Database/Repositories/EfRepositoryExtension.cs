using DrillRoad.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DrillRoad.Database.Repositories;

public static class EfRepositoryExtension
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAdditionalUserRepository, AdditionalUserRepository>();
    }
}