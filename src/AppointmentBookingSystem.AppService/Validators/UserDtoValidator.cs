using FluentValidation;

namespace AppointmentBookingSystem.AppService.Dtos;

public class UserDtoValidator : AbstractValidator<UserDto>
{
    public UserDtoValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required");
        RuleFor(x => x.EmailId).NotEmpty().WithMessage("Email is required")
                               .EmailAddress().WithMessage("Invalid email address");
        RuleFor(x => x.Age).GreaterThan(0).WithMessage("Age must be greater than 0");
        RuleFor(x =>x.UserPassword).NotEmpty().WithMessage("Password is required");
        RuleFor(x => x.UserRole).NotEmpty().WithMessage("Role is required");
    }
}
