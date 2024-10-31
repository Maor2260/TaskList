using Service.DateTime.DTOs;

namespace Service.DateTime;

public class DateTimeService : IDateTimeService
{
    public System.DateTime GetCurrentDateTime(GetDateTimeDTO request)
    {
        return System.DateTime.Now;
    }
}