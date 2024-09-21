// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
//
// namespace DrillRoad.Database.Bootstrap
// {
//     public static class EfBootstrapHelper
//     {
//         public static void AddCommonEfComponents(this IServiceCollection services)
//         {
//             services.AddScoped<IPostgreSqlConnectionStringProvider, SettingsBasedPostgresSqlConnectionStringProvider>();
//             
//             services.AddDbContext<RoadMapDbContext>((serviceProvider, options) =>
//             {
//                 var connectionStringProvider = serviceProvider.GetRequiredService<IPostgreSqlConnectionStringProvider>();
//                 options.UseNpgsql(connectionStringProvider.GetConnectionString());
//             });
//         }
//     }
// }