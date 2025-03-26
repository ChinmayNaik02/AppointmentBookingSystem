using AppointmentBookingSystem.Infrastructure.Contracts;
using AppointmentBookingSystem.Infrastructure.Data;
using AppointmentBookingSystem.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBookingSystem.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context  = context;
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);
        if (user == null)
        {
            throw new KeyNotFoundException($"The user with id : {id} was not found");
        }
        
        return user;
    }

}
