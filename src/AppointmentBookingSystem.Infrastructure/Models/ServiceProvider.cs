using System.ComponentModel.DataAnnotations;

namespace AppointmentBookingSystem.Infrastructure.Models;

public class ServiceProvider
{
    [Key]
    public int ServiceProviderId {get; set;}

    [Required]
    public string FirstName {get; set;} = string.Empty;

    [Required]
    public string LastName {get; set;} = string.Empty;

    [Required]
    public int Age {get; set;}

    public string EmailId {get; set;} = string.Empty;

    [Required]
    public string ServiceProviderRole {get; set;} = string.Empty;

    public string Specialization {get; set;} = string.Empty;
}
