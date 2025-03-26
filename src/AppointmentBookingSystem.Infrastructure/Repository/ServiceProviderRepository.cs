using AppointmentBookingSystem.Infrastructure.Contracts;
using AppointmentBookingSystem.Infrastructure.Data;
using AppointmentBookingSystem.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBookingSystem.Infrastructure.Repository;

public class ServiceProviderRepository : IServiceProviderRepository
{
    private readonly AppDbContext _context;

    public ServiceProviderRepository(AppDbContext context)
    {
        _context  = context;
    }


    public async Task<List<ServiceProvider>> GetAllServiceProviders()
    {
        var serviceProviders = await _context.ServiceProviders.ToListAsync();
        return serviceProviders;
    }

    public async Task<ServiceProvider> GetServiceProviderById(int id)
    {
        var serviceProvider = await _context.ServiceProviders.FirstOrDefaultAsync(s => s.ServiceProviderId == id);
        if (serviceProvider == null)
        {
            throw new KeyNotFoundException($"The serviceProvider with id : {id} was not found");
        }
        
        return serviceProvider;
    }
}
