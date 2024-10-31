using Facade.DTOs.Core;

namespace Facade.DTOs.Time;

public class GetDateTimeResponse : IResponse
{
    public DateTimeStamp DateTime { get; set; }
}