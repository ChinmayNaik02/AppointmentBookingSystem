using System.ComponentModel.DataAnnotations;

namespace AppointmentBookingSystem.AppService.Dtos;

public class UserDto
{
    [Key]
    public int UserId {get; set;}

    [Required]
    [MaxLength(50)]
    public string FirstName {get; set;} = string.Empty;

    [Required]
    [MaxLength(50)]
    public string LastName {get; set;} = string.Empty;

    [Required]
    public int Age {get; set;}

    [MaxLength(100)]
    public string EmailId {get; set;} = string.Empty;

    [MaxLength(50)]
    public string UserPassword {get; set;} = string.Empty;

    [Required]
    [MaxLength(50)]
    public string UserRole {get; set;} = "User";
}
