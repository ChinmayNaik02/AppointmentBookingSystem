using AppointmentBookingSystem.AppService.Contracts;
using AppointmentBookingSystem.AppService.Dtos;
using AppointmentBookingSystem.Infrastructure.Contracts;
using AppointmentBookingSystem.Infrastructure.Models;
using AutoMapper;

namespace AppointmentBookingSystem.AppService.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IAuthenticationRepository _repository;
    private readonly IMapper _mapper;

    public AuthenticationService(IAuthenticationRepository authenticationRepository, IMapper mapper)
    {
        _repository = authenticationRepository;
        _mapper = mapper;
    }

    public async Task<bool> LoginAsync(string email, string password)
    {
        StringValidator(email);
        StringValidator(password);

        bool isAuthenticated =  await _repository.LoginUserAsync(email, password);
        return isAuthenticated;
    }

    public async Task RegisterAsync(UserDto userDto)
    {
        User user =  _mapper.Map<User>(userDto);
        await _repository.RegisterUserAsync(user);
    }

    private static void StringValidator(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            throw new ArgumentException("Invalid input");
        }
    }
}
