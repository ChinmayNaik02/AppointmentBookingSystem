using AppointmentBookingSystem.AppService.Dtos;

namespace AppointmentBookingSystem.AppService.Contracts;

public interface IAuthenticationService
{
    Task RegisterAsync(UserDto userDto);

    Task<bool> LoginAsync(string email, string password);
}
