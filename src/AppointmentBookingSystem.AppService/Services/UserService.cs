using AppointmentBookingSystem.AppService.Contracts;
using AppointmentBookingSystem.AppService.Dtos;
using AppointmentBookingSystem.Infrastructure.Contracts;
using AutoMapper;

namespace AppointmentBookingSystem.AppService.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _repository = userRepository;
        _mapper = mapper;
    }
    public async Task<UserDto> GetByIdAsync(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Invalid Id");
        }

        var user = await _repository.GetUserByIdAsync(id);

        return _mapper.Map<UserDto>(user);
    }

}
