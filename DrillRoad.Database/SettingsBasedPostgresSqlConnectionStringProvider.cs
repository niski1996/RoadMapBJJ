using Microsoft.Extensions.Options;

namespace DrillRoad.Database;

public class SettingsBasedPostgresSqlConnectionStringProvider(IOptions<PostgreSqlSettings> settings) : IPostgreSqlConnectionStringProvider
{
    private readonly string? _connectionString = settings.Value.BuildConnectionString();

    public string GetConnectionString()
    =>_connectionString ?? throw new InvalidOperationException("Connection string cannot be accessed before IStartupInitializers are executed.");
    
}