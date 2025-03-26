using AppointmentBookingSystem.AppService.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentBookingSystem.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServiceProvidersController : ControllerBase
{
    private readonly IServiceProviderService _service;
    private readonly ILogger<ServiceProvidersController> _logger;

    public ServiceProvidersController(IServiceProviderService service, ILogger<ServiceProvidersController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetServiceProviderById(int id)
    {
        try
        {
            var serviceProvider = await _service.GetByIdAsync(id);
            return Ok(serviceProvider);
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

    [HttpGet]
    public async Task<IActionResult> GetAllServiceProviders()
    {
        try
        {
            var serviceProviders = await _service.GetAllByAsync();
            return Ok(serviceProviders);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(500, e.Message);
        }
    }
}
