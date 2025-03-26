using AppointmentBookingSystem.Infrastructure.Models;

namespace AppointmentBookingSystem.Infrastructure.Contracts;

public interface IAuthenticationRepository
{
    Task RegisterUserAsync(User user);

    Task<bool> LoginUserAsync(string emailId, string password);
}
