using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentBookingSystem.AppService.Dtos;

public class AppointmentDto
{
    [Key]
    public int AppointmentId {get; set;}
    public int UserId {get; set;}
    public int ServiceProviderId {get; set;}
    public string AppointmentDescription {get; set;} = string.Empty;
}
