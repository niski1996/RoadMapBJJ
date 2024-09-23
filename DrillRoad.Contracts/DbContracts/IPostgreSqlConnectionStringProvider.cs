namespace DrillRoad.Contracts.DbContracts;

public interface IPostgreSqlConnectionStringProvider
{
    string GetConnectionString();
}