using AppointmentBookingSystem.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBookingSystem.Infrastructure.Data;

public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    { }

    public DbSet<User> Users {get; set;} 
    public DbSet<ServiceProvider> ServiceProviders {get; set;} 
    public DbSet<Appointment> Appointments {get; set;} 
    public DbSet<Slot> Slots {get; set;} 
}
