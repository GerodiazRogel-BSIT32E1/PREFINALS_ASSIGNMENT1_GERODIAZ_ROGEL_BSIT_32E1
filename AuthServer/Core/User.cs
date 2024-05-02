using AuthServer.Core;

namespace AuthServer.Core
{
    public class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        // Add other properties as needed...
    }
}