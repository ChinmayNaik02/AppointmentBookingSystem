using AppointmentBookingSystem.AppService.Contracts;
using AppointmentBookingSystem.AppService.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentBookingSystem.AppService.Extensions;

public static class ServiceExtension
{
   public static void AddAppServices(this IServiceCollection services)
   {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IServiceProviderService, ServiceProviderService>();
        services.AddScoped<IAppointmentService, AppointmentService>();
   }
}