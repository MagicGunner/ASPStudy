using ASPDemo1.Model;

namespace ASPDemo1.Repository;

public interface IUserRepository {
    Task<List<User>> Query();
}