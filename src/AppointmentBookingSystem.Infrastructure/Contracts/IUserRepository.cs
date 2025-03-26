using AppointmentBookingSystem.Infrastructure.Models;

namespace AppointmentBookingSystem.Infrastructure.Contracts;

public interface IUserRepository
{
    Task<User> GetUserByIdAsync(int id);
}
