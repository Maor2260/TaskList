using static Mapper.DTOs.DateTimeMapper;
using Facade.Controllers;
using Facade.DTOs.Time;
using Microsoft.AspNetCore.Mvc;
using Service.DateTime;

namespace Controllers;

[ApiController]
[Route("DateTime")]
public class DateTimeController : Controller, DateTimeFacade
{
    private IDateTimeService _dateTimeService;

    public DateTimeController(IDateTimeService dateTimeService)
    {
        _dateTimeService = dateTimeService;
    }

    [HttpGet]
    [Route("GetDateTime")]
    public ActionResult<GetDateTimeResponse> GetDateTimeREST([FromRoute] GetDateTimeRequest request)
    {
        return GetDateTime(request);
    }
    
    [HttpPost]
    [Route("GetDateTime")]
    public ActionResult<GetDateTimeResponse> GetDateTime(GetDateTimeRequest request)
    {
        var currentDateTime = _dateTimeService.GetCurrentDateTime(request.toDTO());
        return Ok(GetDateTimeReponse(currentDateTime));
    }
}