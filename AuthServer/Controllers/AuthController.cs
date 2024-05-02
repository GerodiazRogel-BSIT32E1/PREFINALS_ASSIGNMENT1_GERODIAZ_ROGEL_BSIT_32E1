using Microsoft.AspNetCore.Mvc;
using AuthServer.Core;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IAuthService _authService;

    public AuthController(IUserService userService, IAuthService authService)
    {
        _userService = userService;
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(User user)
    {
        await _userService.CreateUser(user);
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(string username)
    {
        var user = await _userService.GetUserByUsername(username);
        var token = await _authService.GenerateJwtToken(user);
        return Ok(new { Token = token });
    }
}