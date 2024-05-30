using BurberDinner.Application.Services.Authentication;
using BurberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BurberDinner.Api;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var res = _authenticationService.Register(request.FirstName,
            request.LastName, request.Email, request.Password);

        var response = new AuthenticarionResponse(
            res.User.Id,
            res.User.FirstName,
            res.User.LastName,
            res.User.Email,
            res.Token);

        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var res = _authenticationService.Login(request.Email, request.Password);

        var response = new AuthenticarionResponse(
            res.User.Id,
            res.User.FirstName,
            res.User.LastName,
            res.User.Email,
            res.Token);

        return Ok(response);
    }
}
