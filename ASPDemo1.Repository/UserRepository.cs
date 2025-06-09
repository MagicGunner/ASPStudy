using ASPDemo1.Model;
using Newtonsoft.Json;

namespace ASPDemo1.Repository;

public class UserRepository : IUserRepository {
    public async Task<List<User>> Query() {
        await Task.CompletedTask;
        var data = "[{\"Id\":18,\"Name\":\"MissBlue\"}]";
        return JsonConvert.DeserializeObject<List<User>>(data) ?? [];
    }
}