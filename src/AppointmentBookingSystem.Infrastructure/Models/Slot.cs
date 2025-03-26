using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentBookingSystem.Infrastructure.Models;

public class Slot
{
    [Key]
    public int SlotId {get; set;}
    public DateOnly SlotDate {get; set;}
    public TimeOnly SlotStartTime {get; set;}
    public TimeOnly SlotEndTime {get; set;}

    [ForeignKey("serviceProvider")]
    public int ServiceProviderId {get; set;}
    public virtual ServiceProvider? serviceProvider {get; set;}
}
