using AuthServer.Core;
using System.Threading.Tasks;

namespace AuthServer.Core
{
    public interface IUserService
    {
        Task<User> GetUserByUsername(string username);
        Task CreateUser(User user);
        // Add other methods as needed...
    }
}