namespace ASPDemo1.IService;

public interface IBaseService<TEntity, TVo> where TEntity : class {
    Task<List<TVo>> Query();
}