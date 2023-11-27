namespace WithIn.Application.Common.Interfaces;

public interface IGenericRepository<T>
{
    void Add(T entity);
    void Delete(T entity);
    Task<List<T>> GetAll();
}
