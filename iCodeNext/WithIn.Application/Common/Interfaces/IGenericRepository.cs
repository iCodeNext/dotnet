namespace WithIn.Application.Common.Interfaces;

public interface IGenericRepository<T>
{
    IQueryable<T> GetQueryable();
    void Add(T entity);
    void Delete(T entity);
    Task<List<T>> GetAll();
}
