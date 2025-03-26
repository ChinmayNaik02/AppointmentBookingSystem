using AppointmentBookingSystem.AppService.Dtos;

namespace AppointmentBookingSystem.AppService.Contracts;

public interface IUserService
{
    Task<UserDto> GetByIdAsync(int id);
}
