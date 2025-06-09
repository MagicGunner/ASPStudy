using ASPDemo1.IService;
using ASPDemo1.Model;
using ASPDemo1.Repository;

namespace ASPDemo1.Service;

public class UserService : IUserService {
    public async Task<List<UserVo>> Query() {
        var userRepo = new UserRepository();
        var users = await userRepo.Query();
        return users.Select(i => new UserVo { UserName = i.Name }).ToList();
    }
}