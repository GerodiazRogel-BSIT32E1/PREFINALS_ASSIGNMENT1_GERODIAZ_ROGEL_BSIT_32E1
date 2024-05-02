public interface IAuthService
{
    Task<string> GenerateJwtToken(User user);
}