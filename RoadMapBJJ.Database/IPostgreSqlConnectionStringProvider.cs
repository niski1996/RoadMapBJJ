namespace RoadMapBJJ.Database;

public interface IPostgreSqlConnectionStringProvider
{
    string GetConnectionString();
}