using AppointmentBookingSystem.Infrastructure.Contracts;
using AppointmentBookingSystem.Infrastructure.Data;
using AppointmentBookingSystem.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBookingSystem.Infrastructure.Repository;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly AppDbContext _context;

    public AppointmentRepository(AppDbContext context)
    {
        _context  = context;
    }

    public async Task AddAppointment(Appointment appointment)
    {
        var appointment1 = await _context.Appointments.AddAsync(appointment);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Appointment>> GetAppointmentByServiceProvider(int id)
    {
        var appointment = await _context.Appointments.Include(a => a.serviceProvider).Where(a => a.ServiceProviderId == id).ToListAsync();
        if (appointment == null)
        {
            throw new KeyNotFoundException($"The appointments of ServiceProvider with id : {id} was not found");
        }
        
        return appointment;
    }

    public async Task<List<Appointment>> GetAppointmentByUser(int id)
    {
        var appointment = await _context.Appointments.Where(s => s.UserId == id).ToListAsync();
        if (appointment == null)
        {
            throw new KeyNotFoundException($"The appointments of user with id : {id} was not found");
        }
        
        return appointment;
    }

    public async Task UpdateAppointment(int id, Appointment appointment)
    {
        var appointment1 = await _context.Appointments.FirstOrDefaultAsync(a => a.AppointmentId == id);

        if (appointment1 == null)
        {
            throw new KeyNotFoundException($"The appointment with id : {id} was not found");
        }

        appointment1.AppointmentId = appointment.AppointmentId;
        appointment1.UserId = appointment.UserId;
        appointment1.ServiceProviderId = appointment.ServiceProviderId;
        appointment1.AppointmentDescription = appointment.AppointmentDescription;

        await _context.SaveChangesAsync();
    }

}
