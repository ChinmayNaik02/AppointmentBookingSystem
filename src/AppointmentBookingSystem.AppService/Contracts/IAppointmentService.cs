using AppointmentBookingSystem.AppService.Dtos;

namespace AppointmentBookingSystem.AppService.Contracts;

public interface IAppointmentService
{
    Task AddAsync(AppointmentDto appointmentDto);

    Task<List<AppointmentDto>> GetByServiceProviderAsync(int id);

    Task<List<AppointmentDto>> GetByUserAsync(int id);

    Task UpdateAsync(int id, AppointmentDto appointmentDto);
}
