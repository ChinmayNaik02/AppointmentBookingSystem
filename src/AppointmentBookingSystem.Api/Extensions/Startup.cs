using System.Reflection;
using AppointmentBookingSystem.AppService.Configurations;
using AppointmentBookingSystem.AppService.Extensions;
using AppointmentBookingSystem.Infrastructure.Extensions;
using FluentValidation.AspNetCore;

namespace AppointmentBookingSystem.Api.Extensions;

public static class Startup
{
    [Obsolete]
    public static void AddStartupServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(typeof(AutoMapperConfigurations));
        builder.Services.AddControllers()
                        .AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(Assembly.Load("AppointmentBookingSystem.AppService")));
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddAppServices();
        builder.Services.AddInfrastructure(builder.Configuration);
    }
}
