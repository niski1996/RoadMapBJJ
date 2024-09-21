namespace DrillRoad.Database;

public interface IPostgreSqlConnectionStringProvider
{
    string GetConnectionString();
}