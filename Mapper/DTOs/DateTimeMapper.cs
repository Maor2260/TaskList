using Facade.DTOs.Time;
using Service.DateTime.DTOs;

namespace Mapper.DTOs;

public static class DateTimeMapper
{
    public static GetDateTimeDTO toDTO(this GetDateTimeRequest request)
    {
        return new GetDateTimeDTO() { };
    }

    public static GetDateTimeResponse GetDateTimeReponse(DateTime dateTime)
    {
        return new GetDateTimeResponse()
        {
            DateTime = dateTime.fromDTO()
        };
    }
    
}