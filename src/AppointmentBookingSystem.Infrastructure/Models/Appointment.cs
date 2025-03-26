using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentBookingSystem.Infrastructure.Models;

public class Appointment
{
    [Key]
    public int AppointmentId {get; set;}

    [ForeignKey("user")]
    public int UserId {get; set;}
    public virtual  User? user {get; set;} 

    [ForeignKey("serviceProvider")]
    public int ServiceProviderId {get; set;}
    public virtual ServiceProvider? serviceProvider {get; set;}

    public string AppointmentDescription {get; set;} = string.Empty;
}
