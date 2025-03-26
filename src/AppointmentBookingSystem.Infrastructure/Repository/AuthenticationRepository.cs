using System.Threading.Tasks;
using AppointmentBookingSystem.Infrastructure.Contracts;
using AppointmentBookingSystem.Infrastructure.Data;
using AppointmentBookingSystem.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBookingSystem.Infrastructure.Repository;

public class AuthenticationRepository : IAuthenticationRepository
{
    private readonly AppDbContext _context;

    public AuthenticationRepository(AppDbContext context)
    {
        _context  = context;
    }


    public async Task<bool> LoginUserAsync(string emailId, string password)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.EmailId == emailId);

        if (user == null)
        {
            throw new KeyNotFoundException($"The email Id : {emailId} was not found");
        }

        else
        {
            if (user.UserPassword == password)
            {
                return true;
            }

            return false;
        }
    }

    public async Task RegisterUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

}
