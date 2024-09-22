using System.Linq.Expressions;

public interface IRepository<T> where T : class
{
    // Retrieves all items from the data source
    Task<IEnumerable<T>> GetAllAsync();

    // Retrieves a single item by its ID
    Task<T?> GetByIdAsync(int id);

    // Retrieves items that match a certain condition (predicate)
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

    // Adds a new item to the data source
    Task AddAsync(T entity);

    // Updates an existing item in the data source
    void Update(T entity);

    // Deletes an item from the data source by its ID
    Task DeleteAsync(int id);

    // Saves changes to the data source
    Task SaveAsync();
}