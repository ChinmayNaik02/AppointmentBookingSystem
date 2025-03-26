using AppointmentBookingSystem.AppService.Dtos;
using FluentValidation;

namespace AppointmentBookingSystem.AppService.Validators;

public class AppointmentDtoValidator : AbstractValidator<AppointmentDto>
{
    public AppointmentDtoValidator()
    {
        RuleFor(x => x.UserId).GreaterThan(0).WithMessage("User Id must be greater than 0");
        RuleFor(x => x.ServiceProviderId).GreaterThan(0).WithMessage("Service Provider Id must be greater than 0");
        RuleFor(x => x.AppointmentDescription).NotEmpty().WithMessage("Appointment Description is required");
    }
}
