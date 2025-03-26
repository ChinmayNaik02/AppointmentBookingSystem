using AppointmentBookingSystem.AppService.Contracts;
using AppointmentBookingSystem.AppService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentBookingSystem.Api.Controllers; 

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly IAppointmentService _service;
    private readonly ILogger<AppointmentsController> _logger;

    public AppointmentsController(IAppointmentService service, ILogger<AppointmentsController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet("provider/{id}")]
    public async Task<IActionResult> GetAppointmentByServiceProvider(int id)
    {
        try
        {
            var appointments = await _service.GetByServiceProviderAsync(id);
            return Ok(appointments);
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
    }

    [HttpGet("user/{id}")]
    public async Task<IActionResult> GetAppointmentByUser(int id)
    {
        try
        {
            var appointments = await _service.GetByUserAsync(id);
            return Ok(appointments);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(500, e.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> BookAppointment([FromBody] AppointmentDto appointmentDto)
    {
        try
        {
            await _service.AddAsync(appointmentDto);
            return Ok(appointmentDto);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(500, e.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAppointment(int id, AppointmentDto appointmentDto)
    {
        try
        {
            await _service.UpdateAsync(id, appointmentDto);
            return NoContent();
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
