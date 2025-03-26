using AppointmentBookingSystem.AppService.Contracts;
using AppointmentBookingSystem.AppService.Dtos;
using AppointmentBookingSystem.Infrastructure.Contracts;
using AppointmentBookingSystem.Infrastructure.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using static AppointmentBookingSystem.AppService.Helpers.IdValidationHelper;


namespace AppointmentBookingSystem.AppService.Services;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _repository;
    private readonly IMapper _mapper;

    public AppointmentService(IAppointmentRepository serviceProviderRepository, IMapper mapper)
    {
        _repository = serviceProviderRepository;
        _mapper = mapper;
    }
    public async Task AddAsync(AppointmentDto appointmentDto)
    {
        var appointment = _mapper.Map<Appointment>(appointmentDto);
        await _repository.AddAppointment(appointment);
    }

    public async Task<List<AppointmentDto>> GetByServiceProviderAsync(int id)
    {
        ValidateId(id);
        var appointments = await _repository.GetAppointmentByServiceProvider(id);

        return _mapper.Map<List<AppointmentDto>>(appointments);
    }

    public async Task<List<AppointmentDto>> GetByUserAsync(int id)
    {
        ValidateId(id);
        var appointments = await _repository.GetAppointmentByUser(id);
        
        return _mapper.Map<List<AppointmentDto>>(appointments);
    }

    public async Task UpdateAsync(int id, AppointmentDto appointmentDto)
    {
        var appointment = _mapper.Map<Appointment>(appointmentDto); 
        await _repository.UpdateAppointment(id, appointment);
    }
}
