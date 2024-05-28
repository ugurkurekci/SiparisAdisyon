using Microsoft.AspNetCore.Mvc;
using SiparisAdisyon.Business.Abstract;
using SiparisAdisyon.Business.Dtos.Auths;

namespace SiparisAdisyon.API.Controllers;
[Route("api/[controller]")]
[ApiController]

public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(LoginDto loginDto)
    {
        var result = await _authService.LoginAsync(loginDto);
        return result.Match<IActionResult>(
                       success => Ok(success),
                                  error => BadRequest(error)
                                         );
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync(RegisterDto registerDto)
    {
        var result = await _authService.RegisterAsync(registerDto);
        return result.Match<IActionResult>(
                                  success => Ok(success),
                                                                   error => BadRequest(error)
                                                                                                           );
    }

    [HttpGet("GetAllPersonalDetail")]
    public async Task<IActionResult> GetAllPersonalDetail()
    {
        var result = await _authService.GetAllPersonalDetail();
        var personalDetailDtos = new List<PersonalDetailDto>();
        foreach (var item in result)
        {
            personalDetailDtos.Add(item.AsT0);
        }

        return Ok(personalDetailDtos);

    }

}