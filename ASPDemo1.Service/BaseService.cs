using ASPDemo1.IService;
using ASPDemo1.Repository.Base;
using AutoMapper;

namespace ASPDemo1.Service;

public class BaseService<TEntity, TVo>(IMapper mapper, IBaseRepository<TEntity> repo) : IBaseService<TEntity, TVo>
    where TEntity : class, new() {
    public async Task<List<TVo>> Query() {
        var entities = await repo.Query();
        return mapper.Map<List<TVo>>(entities);
    }
}