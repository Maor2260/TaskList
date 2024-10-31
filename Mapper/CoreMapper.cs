using Facade.DTOs.Core;

namespace Mapper;

public static class CoreMapper
{
    public static DateTime toDTO(this DateTimeStamp dateTimeStamp)
    {
        return new DateTime(dateTimeStamp.Date, dateTimeStamp.Time);
    }
    
    public static DateTimeStamp fromDTO(this DateTime dateTime)
    {
        return new DateTimeStamp()
        {
            Date = DateOnly.FromDateTime(dateTime),
            Time = TimeOnly.FromDateTime(dateTime)
        };
    }
}