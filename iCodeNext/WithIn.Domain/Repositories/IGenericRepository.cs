using System.Linq.Expressions;

namespace WithIn.Domain.Repositories;

public interface IGenericRepository<T>
{
    void Add(T entity);
    Task<T> FindAsync();
    Task<T> FirstOrDefault(Expression<Func<T, bool>> expression);
    void Remove(T entity);
}
