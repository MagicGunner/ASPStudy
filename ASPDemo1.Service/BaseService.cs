using ASPDemo1.IService;
using ASPDemo1.Repository.Base;
using AutoMapper;

namespace ASPDemo1.Service;

public class BaseService<TEntity, TVo>(IMapper mapper) : IBaseService<TEntity, TVo>
    where TEntity : class, new() {
    public async Task<List<TVo>> Query() {
        var baseRepo = new BaseRepository<TEntity>();
        var entities = await baseRepo.Query();
        return mapper.Map<List<TVo>>(entities);
    }
}