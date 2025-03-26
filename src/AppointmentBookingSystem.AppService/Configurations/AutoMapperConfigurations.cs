using AppointmentBookingSystem.AppService.Dtos;
using AppointmentBookingSystem.Infrastructure.Models;
using AutoMapper;

namespace AppointmentBookingSystem.AppService.Configurations;

public class AutoMapperConfigurations : Profile
{
    public AutoMapperConfigurations()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<ServiceProvider, ServiceProviderDto>().ReverseMap();
        CreateMap<Appointment, AppointmentDto>().ReverseMap();
    }
}
