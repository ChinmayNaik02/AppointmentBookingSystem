using System.ComponentModel.DataAnnotations;

namespace AppointmentBookingSystem.AppService.Dtos;

public class ServiceProviderDto
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
