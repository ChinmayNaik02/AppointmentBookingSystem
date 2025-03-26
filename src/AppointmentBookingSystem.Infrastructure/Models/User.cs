using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace AppointmentBookingSystem.Infrastructure.Models;

public class User
{
    [Key]
    public int UserId {get; set;}

    [Required]
    public string FirstName {get; set;} = string.Empty;

    [Required]
    public string LastName {get; set;} = string.Empty;

    [Required]
    public int Age {get; set;}

    public string EmailId {get; set;} = string.Empty;

    public string UserPassword {get; set;} = string.Empty;

    [Required]
    public string UserRole {get; set;} = "User";
}
