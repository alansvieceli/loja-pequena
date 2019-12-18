namespace StoredBuild.Domain.Interfaces
{
  public interface IRepository<TEntity>
  {
    TEntity GetById(int id);
    void Save(TEntity entity);
  }
}