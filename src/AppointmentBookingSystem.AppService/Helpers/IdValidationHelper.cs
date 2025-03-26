namespace AppointmentBookingSystem.AppService.Helpers;

public class IdValidationHelper
{
    public static void ValidateId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Invalid ID");
        }
    }
}
