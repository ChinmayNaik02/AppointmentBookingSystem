using AppointmentBookingSystem.AppService.Contracts;
using AppointmentBookingSystem.AppService.Dtos;
using AppointmentBookingSystem.Infrastructure.Contracts;
using AutoMapper;
using static AppointmentBookingSystem.AppService.Helpers.IdValidationHelper;

namespace AppointmentBookingSystem.AppService.Services;

public class ServiceProviderService : IServiceProviderService
{
    private readonly IServiceProviderRepository _repository;
    private readonly IMapper _mapper;

    public ServiceProviderService(IServiceProviderRepository serviceProviderRepository, IMapper mapper)
    {
        _repository = serviceProviderRepository;
        _mapper = mapper;
    }
    
    public async Task<List<ServiceProviderDto>> GetAllByAsync()
    {
        var serviceProviders = await _repository.GetAllServiceProviders();
        return _mapper.Map<List<ServiceProviderDto>>(serviceProviders);
    }

    public async Task<ServiceProviderDto> GetByIdAsync(int id)
    {
        ValidateId(id);

        var serviceProvider = await _repository.GetServiceProviderById(id);
        return _mapper.Map<ServiceProviderDto>(serviceProvider);
    }
}
