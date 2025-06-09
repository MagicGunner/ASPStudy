using Newtonsoft.Json;

namespace ASPDemo1.Repository.Base;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new() {
    public async Task<List<TEntity>> Query() {
        await Task.CompletedTask;
        var data = "[{\"Id\":18,\"Name\":\"MagicGunner\"}]";
        return JsonConvert.DeserializeObject<List<TEntity>>(data) ?? [];
    }
}