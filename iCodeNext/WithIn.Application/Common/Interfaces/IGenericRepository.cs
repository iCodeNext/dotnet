namespace WithIn.Application.Common.Interfaces;

public interface IGenericRepository<TEntity>
{
    void Add(TEntity entity);
    Task<TEntity> Get(int id);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}
