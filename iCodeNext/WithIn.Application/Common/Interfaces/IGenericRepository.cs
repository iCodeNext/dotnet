namespace WithIn.Application.Common.Interfaces;
public interface IGenericRepository<TEntity>
{
    TEntity Get(int id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}
