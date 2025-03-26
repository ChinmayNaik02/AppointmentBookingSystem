using AppointmentBookingSystem.AppService.Dtos;

namespace AppointmentBookingSystem.AppService.Contracts;

public interface IServiceProviderService
{
    Task<ServiceProviderDto> GetByIdAsync(int id);

    Task<List<ServiceProviderDto>> GetAllByAsync();
}
