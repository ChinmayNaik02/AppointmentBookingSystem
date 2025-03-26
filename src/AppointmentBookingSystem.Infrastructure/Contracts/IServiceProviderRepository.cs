using AppointmentBookingSystem.Infrastructure.Models;

namespace AppointmentBookingSystem.Infrastructure.Contracts;

public interface IServiceProviderRepository
{
    Task<List<ServiceProvider>> GetAllServiceProviders();
    Task<ServiceProvider> GetServiceProviderById(int id);
}
