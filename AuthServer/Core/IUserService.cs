public interface IUserService
{
    Task<User> GetUserByUsername(string username);
    Task CreateUser(User user);
}