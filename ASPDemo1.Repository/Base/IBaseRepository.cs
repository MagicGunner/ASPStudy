namespace ASPDemo1.Repository.Base;

public interface IBaseRepository<TEntity> where TEntity : class {
    Task<List<TEntity>> Query();
}