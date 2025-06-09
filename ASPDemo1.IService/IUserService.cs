using ASPDemo1.Model;

namespace ASPDemo1.IService;

public interface IUserService {
    Task<List<UserVo>> Query();
}