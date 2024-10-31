using Service.DateTime.DTOs;

namespace Service.DateTime;

public interface IDateTimeService
{
    System.DateTime GetCurrentDateTime(GetDateTimeDTO request);
}