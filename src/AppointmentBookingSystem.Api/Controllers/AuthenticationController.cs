using AppointmentBookingSystem.AppService.Contracts;
using AppointmentBookingSystem.AppService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentBookingSystem.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _service;
    private readonly ILogger<AuthenticationController> _logger;

    public AuthenticationController(IAuthenticationService service, ILogger<AuthenticationController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser([FromBody] UserDto userDto)
    {
        try
        {
            await _service.RegisterAsync(userDto);
            return Created();
        }
        catch (ArgumentException e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(500, e.Message);
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginUser([FromBody] LoginDto loginDto)
    {
        try
        {
            if (await _service.LoginAsync(loginDto.EmailId, loginDto.Password))
            {
                return Accepted("Logged in successfully");
            }
            
            else
            {
                return BadRequest("Wrong password");
            }
        }
        catch (ArgumentException e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
        catch(KeyNotFoundException e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(500, e.Message);
        }
    }
}
