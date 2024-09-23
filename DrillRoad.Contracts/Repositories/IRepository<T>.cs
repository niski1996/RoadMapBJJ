using System.Linq.Expressions;

public interface IBaseRepository<T> where T : class
{
    
    // Retrieves a single item by its ID
    Task<T?> GetByIdAsync(int id);
    

    // Adds a new item to the data source
    Task AddAsync(T entity);

    // Deletes an item from the data source by its ID
    Task DeleteAsync(int id);

    // Saves changes to the data source
    Task SaveAsync();
}