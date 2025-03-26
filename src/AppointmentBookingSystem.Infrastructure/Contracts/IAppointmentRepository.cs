using AppointmentBookingSystem.Infrastructure.Models;

namespace AppointmentBookingSystem.Infrastructure.Contracts;

public interface IAppointmentRepository
{
    Task AddAppointment(Appointment appointment);

    Task UpdateAppointment(int id, Appointment appointment);

    Task<List<Appointment>> GetAppointmentByServiceProvider(int id);

    Task<List<Appointment>> GetAppointmentByUser(int id);
}
